namespace Christmas_Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Изчистване на предишния резултат
            textBox3.Clear();

            // || &&

            // Четене на височината на дървото
            int height;
            if (!int.TryParse(textBox1.Text, out height) || height <= 0)
            {
                MessageBox.Show("Моля, въведете положително цяло число за височината!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Четене на символа за дървото
            string symbol = textBox2.Text;
            if (string.IsNullOrEmpty(symbol) || symbol.Length != 1)
            {
                MessageBox.Show("Моля, въведете един-единствен символ!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Рисуване на дървото с вложени цикли
            for (int i = 1; i <= height; i++) // Редове на дървото
            {
                // Добавяне на интервали за центриране
                for (int j = 1; j <= height - i; j++)
                {
                    textBox3.AppendText(" ");
                }

                // Добавяне на символи за дървото
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    textBox3.AppendText(symbol);
                }

                // Нов ред
                textBox3.AppendText(Environment.NewLine);
            }

            // Добавяне на стъблото
            for (int i = 1; i <= height - 1; i++) // Центриране на стъблото
            {
                textBox3.AppendText(" ");
            }
            textBox3.AppendText("  |"); // Стъблото
        }
    }
}
