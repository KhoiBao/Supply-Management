using QLKho.Models;

namespace QLKho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();     
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            //.DataSource = db.SANPHAMs.ToList();
        }
    }
}
