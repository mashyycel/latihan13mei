using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace latihan13mei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand = new MySqlCommand();
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        private void btn_insert_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            string gender;
            if (rb_lakilaki.Checked) gender = "LAKI-LAKI";
            else gender = "PEREMPUAN";
            sqlQuery = $"INSERT INTO pelajar VALUES('{tb_idpelajar.Text}', '{tb_namapelajar.Text}', '{cb_jurusan.Text}', '{tanggallahir.Text}', '{tb_noinduk.Text}', '{tb_notelepon.Text}', '{gender}', '{tb_alamat.Text}', '{cb_angkatan.Text}', '{tb_email.Text}', 0)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show(sqlQuery);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tanggallahir.CustomFormat = "yyyy-MM-dd";
            tanggallahir.Format = DateTimePickerFormat.Custom;
        }
    }
}
