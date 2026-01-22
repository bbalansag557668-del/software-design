using System.Globalization;

namespace Task5OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        class DescendingSorter
        {
            public int[] data = { 3, 1, 5, 2, 4 };

            public DescendingSorter(int[] array)
            {
                data = array;
            }
            public int[] SortDescending()
            {
                int temp;

                for (int i = 0; i < data.Length - 1; i++)
                {
                    for (int j = i + 1; j < data.Length; j++)
                    {
                        if (data[i] < data[j])
                        {

                            temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
                return data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = DescendingSorter data;
            int[] sortedNumbers = SortDescending(nums);
                listBoxResults.DataSource = sortedNumbers;
        }
    }
}
