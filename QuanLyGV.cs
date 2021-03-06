﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLy_HS_GV_THPT
{

    public partial class QuanLyGV : Form
    {
        //Ket noi SQL
        SqlConnection connection;
        SqlCommand command;
        //string dataSource = @"Data Source=DESKTOP-9JCB5HS;Initial Catalog=quanly_Hs_Gv_THPT_3F;Integrated Security=True";
        //SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        //Datasourse (khac nhau)

        DataTable table = new DataTable();

        
       
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from GIAOVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }


        public QuanLyGV()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            dataGridView1.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                var helperDialog = new Helper.Helpers();
                helperDialog.ShowDialog();
            }
        }

        private void QuanLyGV_Load(object sender, EventArgs e)
         {
             connection = new SqlConnection(Helper.Define.dataSource);
             connection.Open();
             loadData();
         }


        private void ReturnGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManHinhChinh manhinhchinh = new ManHinhChinh();
            manhinhchinh.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaGV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenGV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDate.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update LOP set MaGV = null where MaGV = '" + txtMaGV.Text + "'";
            command.ExecuteNonQuery();

            command.CommandText = "delete from GIAOVIEN where MaGV ='" + txtMaGV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            txtMaGV.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update GIAOVIEN set MaGV = N'" + txtMaGV.Text + "', TenGV = '" + txtTenGV.Text + "', GioiTinh = N'" + txtGioiTinh.Text + "' , DiaChi = '" + txtDiaChi.Text + "', SDT = '" + txtPhone.Text + "' where MaGV = '" + txtMaGV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtGioiTinh.Text = "";
            txtDate.Text = "1/1/1900";
            txtPhone.Text = "";
            txtDiaChi.Text = "";
            txtSearch.Text = "";
            loadData();
        }

       


        private void TimKiem_Click(object sender, EventArgs e)
        {
            // tim kiem theo mã giáo viên
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            connection.Open();
           string sql = "select MaGV from GIAOVIEN where MaGV = '" + txtSearch.Text + "' ";

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read() == true)
            {
                data.Close();
                command = connection.CreateCommand();
                command.CommandText = "select * from GIAOVIEN where MaGV= '" + txtSearch.Text + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
           

            // tim kiem theo tên giáo viên
            SqlConnection connection1 = new SqlConnection(Helper.Define.dataSource);
            connection1.Open();
            string sql1 = "select TenGV from GIAOVIEN where TenGV = '" + txtSearch.Text + "' ";

            SqlCommand cmd1 = new SqlCommand(sql1, connection1);
            SqlDataReader data1 = cmd1.ExecuteReader();

            if (data1.Read() == true)
            {
                data1.Close();
                command = connection1.CreateCommand();
                command.CommandText = "select * from GIAOVIEN where TenGV= '" + txtSearch.Text + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }


        private void helpBTN_Click(object sender, EventArgs e)
        {
            var helperDialog = new Helper.Helpers();
            helperDialog.ShowDialog();
        }


       
        private void Them_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            string id = txtMaGV.Text;
            connection.Open();


            string sql = "select * from GIAOVIEN where MaGV = '" + txtMaGV.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {

                MessageBox.Show(" Trùng mã! Mời Nhập lại");
            }
            else
            {
                dta.Close();
                command = connection.CreateCommand();
                command.CommandText = "Insert into GIAOVIEN values('" + txtMaGV.Text + "', N'" + txtTenGV.Text + "','" + txtGioiTinh.Text + "', '"+ txtDate.Text+"', '" + txtPhone.Text + "', N'" + txtDiaChi.Text + "'  )";
                command.ExecuteNonQuery();
                loadData();

            }
        }

        private void txtGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
