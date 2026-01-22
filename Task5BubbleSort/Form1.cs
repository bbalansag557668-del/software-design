namespace Task5BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int temp;

            for (int i = 0; i < 5 - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int[] numbers = { 3, 1, 5, 2, 4 };
                int[] sortedNumbers = BubbleSort(numbers);
                listBoxResults.DataSource = sortedNumbers;
           
        }
    }
}
