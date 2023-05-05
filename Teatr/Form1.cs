namespace Teatr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            forClr.Start();
        }
        int clr = 0;
        private void forClr_Tick(object sender, EventArgs e)
        {
            clr++;
            if (clr < 100) pnlMenu.BackColor = Color.FromArgb(clr, 100 - clr, clr);
            else if (clr < 200) pnlMenu.BackColor = Color.FromArgb(200 - clr, clr - 100, 200 - clr);
            else clr = 0;
        }

        private void btnTeatrAdd_MouseHover(object sender, EventArgs e)
        {
            Theatres.Width = Theatres.Width - 126;
            btnTeatrAdd.Width = 180;
            btnTeatrAdd.Location = new Point(this.Width - 186, 70);
            btnTeatrAdd.Text = "Yangi teatr qo'shish";
        }

        private void btnTeatrAdd_MouseLeave(object sender, EventArgs e)
        {
            Theatres.Width = Theatres.Width + 126;
            btnTeatrAdd.Width = 54;
            btnTeatrAdd.Location = new Point(Theatres.Width + 20, 70);
            btnTeatrAdd.Text = "+";
        }

        private void Theatres_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlTeatrInfo.Height = 800;
        }

        private void btnTeatrAdd_Click(object sender, EventArgs e)
        {
            pnlTheatreAdd.Height = 800;
        }

        private void close1_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "↩️ Ushbu bo'limni yopish";
        }

        private void close1_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "↩️";
        }

        private void close1_Click(object sender, EventArgs e)
        {
            pnlTeatrInfo.Height = 1;
        }

        private void close2_Click(object sender, EventArgs e)
        {
            pnlTheatreAdd.Height = 1;
        }

        private void txtTheatreName_Enter(object sender, EventArgs e)
        {
            pnltxt1.BackColor = Color.FromArgb(30, 30, 255);
        }

        private void txtTheatreName_Leave(object sender, EventArgs e)
        {
            if (txtTheatreName.Text.Length > 0) pnltxt1.BackColor = Color.FromArgb(30, 30, 30);
            else pnltxt1.BackColor = Color.FromArgb(255, 30, 30);
        }

        private void txtTheatreCity_Enter(object sender, EventArgs e)
        {
            pnltxt2.BackColor = Color.FromArgb(30, 30, 255);
        }

        private void txtTheatreCity_Leave(object sender, EventArgs e)
        {
            if (txtTheatreCity.Text.Length > 0) pnltxt2.BackColor = Color.FromArgb(30, 30, 30);
            else pnltxt2.BackColor = Color.FromArgb(255, 30, 30);
        }

        private void txtTheatreAdress_Enter(object sender, EventArgs e)
        {
            pnltxt3.BackColor = Color.FromArgb(30, 30, 255);
        }

        private void txtTheatreAdress_Leave(object sender, EventArgs e)
        {
            if (txtTheatreAdress.Text.Length > 0) pnltxt3.BackColor = Color.FromArgb(30, 30, 30);
            else pnltxt3.BackColor = Color.FromArgb(255, 30, 30);
        }

        private void txtTheatreTel_Enter(object sender, EventArgs e)
        {
            pnltxt4.BackColor = Color.FromArgb(30, 30, 255);
        }

        private void txtTheatreTel_Leave(object sender, EventArgs e)
        {
            if (txtTheatreTel.Text.Length > 0) pnltxt4.BackColor = Color.FromArgb(30, 30, 30);
            else pnltxt4.BackColor = Color.FromArgb(255, 30, 30);
        }

        private void seances_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlSeanse.Height = 720;
        }

        private void btnSeanseAdd_Click(object sender, EventArgs e)
        {
            pnlAddSeanse.Height = 720;
        }

        private void close4_Click(object sender, EventArgs e)
        {
            pnlAddSeanse.Height = 1;
        }

        private void close3_Click(object sender, EventArgs e)
        {
            pnlSeanse.Height = 1;
        }

        private void pnlAddSeanse_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}