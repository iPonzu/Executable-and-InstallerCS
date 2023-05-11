using System;
using System.Windows.Forms;
using System.Drawing;

    static class Program{
        public static void Main(){
            Form tela = new Form();
            tela.Text = "Good morning";
            tela.Size = new System.Drawing.Size(422,203);

            Label lblname = new Label();
            lblname.Text = "Insira seu nome";
            lblname.Location = new System.Drawing.Point(10,10);
            lblname.Size = new System.Drawing.Size(100,60);

            TextBox txtname = new TextBox();
            txtname.Location = new System.Drawing.Point(10,40);
            txtname.Width = 200;

            Button botao1 = new Button();
            botao1.Location = new System.Drawing.Point(10,90);
            botao1.Text = "Olá";
            botao1.Click += (sender, e) => MessageBox.Show($"Olá, {txtname.Text}");
            Button botao2 = new Button();
            botao2.Location = new System.Drawing.Point(10,115);
            botao2.Text = "Fechar";
            botao2.Click += (sender, e) => tela.Close();


            tela.Controls.Add(botao1);
            tela.Controls.Add(botao2);
            tela.Controls.Add(txtname);
            tela.Controls.Add (lblname);




            Application.Run(tela);
        }
    }