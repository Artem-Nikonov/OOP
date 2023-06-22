using System.Text;
using ПР_4.StressTest;

namespace ПР_4
{
    namespace StressTest
    {
        /// <summary>
        /// Enumeration of girder material types
        /// </summary>
        public enum Material
        {
            StainlessSteel,
            Aluminium,
            ReinforcedConcrete,
            Composite,
            Titanium
        }
        /// <summary>
        /// Enumeration of girder cross-sections
        /// </summary>
        public enum CrossSection
        {
            IBeam,
            Box,
            ZShaped,
            CShaped
        }
        /// <summary>
        /// Enumeration of test results
        /// </summary>
        public enum TestResult
        {
            Pass,
            Fail
        }

        public struct TestCaseResult
        {
            /// <summary>
            /// Test result (enumeration type)
            /// </summary>
            public TestResult Result;
            /// <summary>
            /// Description of reason for failure
            /// </summary>
            public string ReasonForFailure;
        }
    }

    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
            material.DataSource = Enum.GetValues(typeof(Material));
            material.ClearSelected();
            crossSection.DataSource = Enum.GetValues(typeof(CrossSection));
            crossSection.ClearSelected();
            testResult.DataSource = Enum.GetValues(typeof(TestResult));
            testResult.ClearSelected();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetRes_Click(object sender, EventArgs e)
        {
            StringBuilder res = new StringBuilder();

            if (material.SelectedItem == null || crossSection.SelectedItem == null || testResult.SelectedItem == null)
            {
                MessageBox.Show("Выберите значения из всех категорий!");
                return;
            }

            res.Append("Material: ");
            switch ((Material)material.SelectedItem)
            {
                case Material.StainlessSteel:
                    res.Append(material.SelectedItem);
                    break;
                case Material.Aluminium:
                    res.Append(material.SelectedItem);
                    break;
                case Material.ReinforcedConcrete:
                    res.Append(material.SelectedItem);
                    break;
                case Material.Composite:
                    res.Append(material.SelectedItem);
                    break;
                case Material.Titanium:
                    res.Append(material.SelectedItem);
                    break;
            }
            res.Append("\n");

            res.Append("CrossSection: ");
            switch ((CrossSection)crossSection.SelectedItem)
            {
                case CrossSection.IBeam:
                    res.Append(crossSection.SelectedItem);
                    break;
                case CrossSection.Box:
                    res.Append(crossSection.SelectedItem);
                    break;
                case CrossSection.ZShaped:
                    res.Append(crossSection.SelectedItem);
                    break;
                case CrossSection.CShaped:
                    res.Append(crossSection.SelectedItem);
                    break;
            }
            res.Append("\n");

            res.Append("TestResult: ");
            switch ((TestResult)testResult.SelectedItem)
            {
                case (TestResult.Pass):
                    res.Append(testResult.SelectedItem);
                    break;
                case (TestResult.Fail):
                    res.Append(testResult.SelectedItem);
                    break;
            }
                
            label1.Text = res.ToString();
        }

        private void tests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public TestCaseResult GetResult()
        {
            TestCaseResult res = new TestCaseResult();
            Random rand = new Random();
            res.Result = (TestResult)rand.Next(0, 2);
            if(res.Result == TestResult.Pass)
            {
                res.ReasonForFailure = "Passed";
                return res;
            }

            switch (rand.Next(0, 4))
            {
                case 0:
                    res.ReasonForFailure = "Error 1";
                    break;
                case 1:
                    res.ReasonForFailure = "Error 2";
                    break;
                case 2:
                    res.ReasonForFailure = "Error 3";
                    break;
                case 3:
                    res.ReasonForFailure = "Error 4";
                    break;
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tests.Items.Clear();
            TestCaseResult[] res = new TestCaseResult [10];

            for(int i = 0; i< res.GetLength(0); i++)
            {
                res[i] = GetResult();
            }

            int PassTests = 0;
            int FailTests = 0;

            for (int i = 0; i < res.GetLength(0); i++)
            {
                tests.Items.Add($"Test {i+1}:\t{res[i].ReasonForFailure}");

                if (res[i].Result == TestResult.Pass)
                {
                    PassTests += 1;
                }
                else
                {
                    FailTests+=1;
                }
            }
            tests.Items.Add($"Passed: {PassTests}\tFailed: {FailTests}");
        }
    }
}