using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogBook.VO;

namespace LogBook.View
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objeto
            Student student = new Student(); //é um objeto
            //Classe objeto = new Constructor ( )
            student.ar = txtAR.Text; // <--  atribuição
            student.studentName = txtStudentName.Text;
            student.miniCurriculum = txtMiniCurriculum.Text;
            student.hobby = txtHobby.Text;
            student.classCode = txtClassCode.Text;

            MessageBox.Show(student.studentName);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
