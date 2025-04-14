using System.Diagnostics.Eventing.Reader;

namespace CosineSimilarity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vectorA = txtVectorA.Text, vectorB = txtVectorB.Text;
            if (string.IsNullOrWhiteSpace(vectorA) || string.IsNullOrWhiteSpace(vectorB))
            {
                MessageBox.Show("Please input both the vectors", "Alert");
                return;
            }
            else
            {
                var vecASplit = vectorA.Trim().Split(',').ToList();
                var vecBSplit = vectorB.Trim().Split(',').ToList();
                if (vecASplit.Count != vecBSplit.Count)
                {
                    MessageBox.Show("The vectors are of different length.", "Alert");
                    return;
                }

                double aDotb = 0.0, aValue = 0.0, bValue = 0.0;
                for(int i = 0; i < vecASplit.Count; i++)
                {
                    aDotb += Convert.ToDouble(vecASplit[i]) * Convert.ToDouble(vecBSplit[i]);
                    aValue += Math.Pow(Convert.ToDouble(vecASplit[i]), 2);
                    bValue += Math.Pow(Convert.ToDouble(vecBSplit[i]), 2);
                }

                double similarity = Math.Round(aDotb / (Math.Sqrt(aValue) * Math.Sqrt(bValue)), 2);     // a.b / |a|.|b|

                if(similarity < 0)
                {
                    progressBar1.ForeColor = Color.Red;
                }
                else
                {
                    progressBar1.ForeColor = Color.Green;
                }

                var value = Math.Abs((int)(similarity * 100));
                lblResult.Text = $"{value}% {(similarity < 0 ? "disimilar" : "similar")}";
                progressBar1.Value = value;
            }
        }
    }
}
