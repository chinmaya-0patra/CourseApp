using System.Data;

namespace CourseApp
{
    public partial class Form1 : Form
    {

        private DataTable dt = new DataTable();
        private DataTable dtSelected = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCourses();
            selectedCourses();

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "CourseName";

            listBox2.DataSource = dtSelected;
            listBox2.DisplayMember = "CourseName";

        }

        private void fillCourses()
        {
            //adding column name
            dt.Columns.Add("CID", typeof(int));
            dt.Columns.Add("CourseName");
            dt.Columns.Add("CourseDuration");

            //adding rows
            dt.Rows.Add(1, "C Programming", "4 months");
            dt.Rows.Add(2, "C++ Programming", "6 months");
            dt.Rows.Add(3, "JAVA Programming", "5 months");
            dt.Rows.Add(4, "C# Programming", "6 months");
            dt.Rows.Add(5, "MySQL database", "6 months");
            dt.Rows.Add(6, "Python Programming", "3 months");
            dt.Rows.Add(7, "Flutter", "12 months");

        }

        private void selectedCourses()
        {
            dtSelected.Columns.Add("CID", typeof(int));
            dtSelected.Columns.Add("CourseName");
            dtSelected.Columns.Add("CourseDuration");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dtSelected.ImportRow(dt.Rows[listBox1.SelectedIndex]);
                dt.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dt.ImportRow(dtSelected.Rows[listBox2.SelectedIndex]);
                dtSelected.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int countItems = dt.Rows.Count;

                for (int i = countItems - 1; i >= 0; i--)
                {
                    dtSelected.ImportRow(dt.Rows[listBox1.SelectedIndex]);
                    dt.Rows[listBox1.SelectedIndex].Delete();
                }
            }

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                int countItems = dtSelected.Rows.Count;

                for (int i = countItems - 1; i >= 0; i--)
                {
                    dt.ImportRow(dtSelected.Rows[listBox2.SelectedIndex]);
                    dtSelected.Rows[listBox2.SelectedIndex].Delete();
                }
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Course Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dr == DialogResult.Yes)
            {
                dataGridView1.DataSource = dtSelected;
                dataGridView1.Enabled = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 550;
                dataGridView1.Columns[2].Width = 425;

            }
            else
            {
                MessageBox.Show("Then You moron, Select your preferred courses!", "Course Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
