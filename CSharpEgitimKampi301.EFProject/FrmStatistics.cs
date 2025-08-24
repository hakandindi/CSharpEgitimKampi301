using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void label2_Click(object sender, EventArgs e)
        {}

        private void label3_Click(object sender, EventArgs e)
        {}

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {}

        private void FrmStatistics_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Locations.Count().ToString();
            lblTotalCapacity.Text = db.Locations.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guides.Count().ToString(); 
            lblAvgCapacity.Text = db.Locations.Average(x => x.Capacity).ToString();
            lblAvgTourPrice.Text = db.Locations.Average(x => x.Price).ToString()+ " $";

            var lastCountryid = db.Locations.Max(x => x.LocationId); //**
            lblLastCountry.Text = db.Locations.Where(x => x.LocationId == lastCountryid).Select(y => y.Country).FirstOrDefault(); //** Select ve FirstOrDefaul methodunu unutma ToStringe gerek yok
            
            lblCapadociaCapacity.Text = db.Locations.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkeyAvgCapacity.Text = db.Locations.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var RomeGuide = db.Locations.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guides.Where(x => x.GuideId == RomeGuide).Select(y => y.GuideName+ " " + y.GuideSurname).FirstOrDefault().ToString();

            var MaxCapacityTour = db.Locations.Max(x => x.Capacity); // **
            lblMaxCapacity.Text = db.Locations.Where(x=> x.Capacity == MaxCapacityTour).Select(y => y.City).FirstOrDefault().ToString(); // **
                
            var MaxPrice = db.Locations.Max(x => x.Price);
            lblMaxPrice.Text = db.Locations.Where(x=> x.Price== MaxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var AysegülId = db.Guides.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(x => x.GuideId).FirstOrDefault();
            lblAysegülTourCount.Text = db.Locations.Where(x => x.GuideId == AysegülId).Count().ToString();
        }
    }
}
