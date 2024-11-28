using System.Data;

namespace WinFormsApp1
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTable todolist = new DataTable();
        bool isEditing = false;
        private void ListToDo_Load(object sender, EventArgs e)
        {
            todolist.Columns.Add("Titulo");
            todolist.Columns.Add("Descri��o");

            ToDoListView.DataSource = todolist;
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            NomeTextBox.Text = "";
            Descri��oTextBox.Text = "";

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            isEditing = true;

            NomeTextBox.Text = todolist.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            Descri��oTextBox.Text = todolist.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
        }

        private void DeletarButton_Click(object sender, EventArgs e)
        {
            try
            {
                todolist.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Nome"] = NomeTextBox.Text;
                todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Descri��o"] = Descri��oTextBox.Text;
            }
            else
            {
                todolist.Rows.Add(NomeTextBox.Text, Descri��oTextBox.Text);
            }
            NomeTextBox.Text = "";
            Descri��oTextBox.Text = "";
            isEditing = false;
        }
    }
}
