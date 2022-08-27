namespace ImageSort
{
    public partial class Form1 : Form
    {
        private int _hydrantScore;
        private int _benchScore;
        private int _trashScore;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _btnAnalyze_Click(object sender, EventArgs e)
        {

        }
        private void LoadAndDetect()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();    
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles("*");
                foreach(string file in files)
                {
                    VehicleModel.ModelInput model = new VehicleModel.ModelInput();
                    model.ImageSource = file;
                    VehicleModel.ModelOutput outputModel = VehicleModel.Predict(model);
                    if (outputModel.Prediction == "Hydrant" && outputModel.Score[0] == 0.75)
                    {

                    }
                    else if (outputModel.Prediction == "Kos" && outputModel.Score[1] == 0.75)
                    {
                        
                    }
                    else if (outputModel.Prediction == "Lavicka" && outputModel.Score[2] == 0.75)
                    {

                    }
                }
            }
        }
    }
}