namespace Listenfeld_Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lst_words.SelectedIndex;
            if (selectedIndex != -1)
                lst_words.Items.RemoveAt(selectedIndex);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_new.Text == "")
                return;
            if (rbtn_start.Checked)
                lst_words.Items.Insert(0, txt_new.Text);
            else if (rbtn_selection.Checked)
            {
                if (lst_words.SelectedIndex != -1)
                    lst_words.Items.Insert(
                    lst_words.SelectedIndex, txt_new.Text);
            }
            else
                lst_words.Items.Add(txt_new.Text);
            txt_new.Text = "";
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            int x = lst_words.SelectedIndex;
            if (txt_replace.Text != "" && x != -1)
            {
                lst_words.Items.RemoveAt(x);
                lst_words.Items.Insert(x, txt_replace.Text);
                txt_replace.Text = "";
            }
        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            lst_words.Items.Clear();
        }
    }
}