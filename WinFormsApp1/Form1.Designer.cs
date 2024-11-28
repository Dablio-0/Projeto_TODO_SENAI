namespace WinFormsApp1
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            NomeTextBox = new TextBox();
            label1 = new Label();
            DescriçãoTextBox = new TextBox();
            label2 = new Label();
            NovoButton = new Button();
            EditarButton = new Button();
            DeletarButton = new Button();
            SalvarButton = new Button();
            ToDoListView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(linkLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1243, 125);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(145, 42);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(225, 40);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lista de tarefas";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // NomeTextBox
            // 
            NomeTextBox.Location = new Point(50, 237);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(558, 27);
            NomeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 209);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // DescriçãoTextBox
            // 
            DescriçãoTextBox.Location = new Point(50, 317);
            DescriçãoTextBox.Name = "DescriçãoTextBox";
            DescriçãoTextBox.Size = new Size(558, 27);
            DescriçãoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 294);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Descrição:";
            // 
            // NovoButton
            // 
            NovoButton.BackColor = Color.White;
            NovoButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NovoButton.Location = new Point(50, 363);
            NovoButton.Name = "NovoButton";
            NovoButton.Size = new Size(240, 80);
            NovoButton.TabIndex = 5;
            NovoButton.Text = "Novo";
            NovoButton.UseVisualStyleBackColor = false;
            NovoButton.Click += NovoButton_Click;
            // 
            // EditarButton
            // 
            EditarButton.BackColor = Color.FromArgb(192, 255, 255);
            EditarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarButton.Location = new Point(340, 363);
            EditarButton.Name = "EditarButton";
            EditarButton.Size = new Size(232, 80);
            EditarButton.TabIndex = 6;
            EditarButton.Text = "Editar";
            EditarButton.UseVisualStyleBackColor = false;
            EditarButton.Click += EditarButton_Click;
            // 
            // DeletarButton
            // 
            DeletarButton.BackColor = Color.Red;
            DeletarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeletarButton.Location = new Point(340, 463);
            DeletarButton.Name = "DeletarButton";
            DeletarButton.Size = new Size(232, 80);
            DeletarButton.TabIndex = 7;
            DeletarButton.Text = "Deletar";
            DeletarButton.UseVisualStyleBackColor = false;
            DeletarButton.Click += DeletarButton_Click;
            // 
            // SalvarButton
            // 
            SalvarButton.BackColor = Color.Lime;
            SalvarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalvarButton.Location = new Point(58, 463);
            SalvarButton.Name = "SalvarButton";
            SalvarButton.Size = new Size(232, 80);
            SalvarButton.TabIndex = 8;
            SalvarButton.Text = "Salvar";
            SalvarButton.UseVisualStyleBackColor = false;
            SalvarButton.Click += SalvarButton_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.BackgroundColor = Color.White;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(651, 162);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.RowHeadersWidth = 51;
            ToDoListView.Size = new Size(560, 636);
            ToDoListView.TabIndex = 9;
            ToDoListView.CellContentClick += ToDoListView_CellContentClick;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.istockphoto_1370858067_612x612;
            ClientSize = new Size(1243, 860);
            Controls.Add(ToDoListView);
            Controls.Add(SalvarButton);
            Controls.Add(DeletarButton);
            Controls.Add(EditarButton);
            Controls.Add(NovoButton);
            Controls.Add(label2);
            Controls.Add(DescriçãoTextBox);
            Controls.Add(label1);
            Controls.Add(NomeTextBox);
            Controls.Add(panel1);
            Name = "ToDoList";
            Text = "Form1";
            Load += ListToDo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private TextBox NomeTextBox;
        private Label label1;
        private TextBox DescriçãoTextBox;
        private Label label2;
        private Button NovoButton;
        private Button EditarButton;
        private Button DeletarButton;
        private Button SalvarButton;
        private DataGridView ToDoListView;
    }
}
