using AddressLibrary;

namespace AddressHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Address> addresses = new List<Address>();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Search(Search_INPT.Text);
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            if (!AdrList_cmb.Items.Contains(Results_cmb.SelectedItem))
            {
                AdrList_cmb.Items.Add(Results_cmb.SelectedItem);
                secondLoc_cmb.Items.Add(Results_cmb.SelectedItem);
            }
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            AdrList_cmb.Items.Remove(AdrList_cmb.SelectedItem);
            AdrList_cmb.Text = "";
            secondLoc_cmb.Items.Remove(secondLoc_cmb.SelectedItem);
            secondLoc_cmb.Text = "";
        }

        private void Results_cmb_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void Search(string text)
        {
            Results_cmb.Items.Clear();
            foreach (Address item in Address.FindAddresses(text))
            {
                Results_cmb.Items.Add(item);
            }
        }

        private void CalcDis_btn_Click(object sender, EventArgs e)
        {
            if(AdrList_cmb.SelectedItem != null && secondLoc_cmb.SelectedItem != null)
            {
                double airdistance = Address.CalcDistance((Address)AdrList_cmb.SelectedItem, (Address)secondLoc_cmb.SelectedItem);
                string cardistance = "ERROR Calculating!";
                try
                {
                    cardistance = Address.CalcDriveDistance((Address)AdrList_cmb.SelectedItem, (Address)secondLoc_cmb.SelectedItem).ToString();
                }
                catch (Exception)  { }
                distance_outp.Text = $"Air: {airdistance}\n" +
                    $"By Car: {cardistance}";

            }
        }
    }
}