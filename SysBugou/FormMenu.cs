using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysBugou
{
    public partial class FormMenu : Form
    {
        int altura = Screen.PrimaryScreen.Bounds.Width;
        int acc = 0;
        public FormMenu()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            menuStrip1.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.DarkGreen; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DarkGreen; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.DarkGreen; }
            }
        }


        private void FormMenu_MouseHover(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            this.Size = new System.Drawing.Size(0, altura);

        }

        private void FormMenu_MouseLeave(object sender, EventArgs e)
        {

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (acc != 0)
            {
                timer1.Stop();
            }

            if (acc == 0)
            {
                timer2.Stop();
            }

            else
            {
                acc -= 25;
                this.Size = new System.Drawing.Size(acc, altura);
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(261, altura);
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            timer1.Start();
            menuStrip1.ForeColor = Color.Transparent;
        }


        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btCadCliente_Click(object sender, EventArgs e)
        {
            //timer2.Start();
            //bool _found = false;
            //foreach (Form _openForm in Application.OpenForms)
            //{
            //    if (_openForm is FormCadLogin)
            //    {
            //        _openForm.Focus();
            //        _found = true;
            //    }
            //}
            //if (!_found)
            //{
            //    FormCadLogin _form2 = new FormCadLogin();
            //    _form2.Show();
            //}


        }

        private void btCadProdutos_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (acc >= 261)
            {
                timer1.Stop();
            }

            else
            {
                acc += 25;
                this.Size = new System.Drawing.Size(acc, altura);
            }
        }

        private void btCadProdutos_Click_1(object sender, EventArgs e)
        {
            //timer2.Start();
            //bool _found = false;
            //foreach (Form _openForm in Application.OpenForms)
            //{
            //    if (_openForm is Form1)
            //    {
            //        _openForm.Focus();
            //        _found = true;
            //    }
            //}
            //if (!_found)
            //{
            //    Form1 _form2 = new Form1();
            //    _form2.Show();
            //}
        }

        private void btSair_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        private void btCadCliente_Click_1(object sender, EventArgs e)
        {
            //timer2.Start();
            //bool _found = false;
            //foreach (Form _openForm in Application.OpenForms)
            //{
            //    if (_openForm is FormCadGeral)
            //    {
            //        _openForm.Focus();
            //        _found = true;
            //    }
            //}
            //if (!_found)
            //{
            //    FormCadGeral _form2 = new FormCadGeral();
            //    _form2.Show();
            //}
        }

        private void btServicos_Click(object sender, EventArgs e)
        {
            //timer2.Start();
            //bool _found = false;
            //foreach (Form _openForm in Application.OpenForms)
            //{
            //    if (_openForm is FormCaixa)
            //    {
            //        _openForm.Focus();
            //        _found = true;
            //    }
            //}
            //if (!_found)
            //{
            //    FormCaixa _form2 = new FormCaixa();
            //    _form2.Show();
            //}
        }

        private void btSobre_Click(object sender, EventArgs e)
        {
            //timer2.Start();
            //bool _found = false;
            //foreach (Form _openForm in Application.OpenForms)
            //{
            //    if (_openForm is FormInfo)
            //    {
            //        _openForm.Focus();
            //        _found = true;
            //    }
            //}
            //if (!_found)
            //{
            //    FormInfo _form2 = new FormInfo();
            //    _form2.ShowDialog();
            //}
        }


    }
}

