using System;
using System.IO;
using System.Windows.Forms;

namespace recruitPGwork
{
    public partial class LunchBoxMemoForm : Form
    {
        private const string NewLine = "\r\n";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LunchBoxMemoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 合計金額を求める
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // 品物が選択されているか判定する
            if (string.IsNullOrWhiteSpace(ItemNameComboBox.Text))
            {
                MessageBox.Show("品物を選択してください");
                return;
            }

            // 個数に1以上の数値が入力されているかチェックする
            if (CountNumericUpDown.Value == 0)
            {
                MessageBox.Show("1つ以上の数字を入力してください");
                return;
            }

            int count = (int)CountNumericUpDown.Value;

            // 単価
            int unitPrice;

            switch (ItemNameComboBox.Text)
            {
                case "ハンバーガー":
                    unitPrice = 250;
                    break;

                case "コロッケパン":
                    unitPrice = 180;
                    break;

                case "メロンパン":
                    unitPrice = 120;
                    break;

                default:
                    unitPrice = 0;
                    break;
            }

            // 今回の金額
            int price = unitPrice * count;

            // 買い物リスト用の文字列を作成する
            string itemLine = ItemNameComboBox.Text + "," + count + "個 = " + price;

            // 買い物リストに追加する
            if (string.IsNullOrWhiteSpace(ItemListTextBox.Text))
            {
                ItemListTextBox.Text = itemLine;
            }
            else
            {
                ItemListTextBox.Text = ItemListTextBox.Text + NewLine + itemLine;
            }

            // グラフ用の文字列を作成する
            string graphLine = "";
            for (int i = 0; i < count; i++)
            {
                graphLine = graphLine + "■";
            }

            // グラフを表示する
            if (string.IsNullOrWhiteSpace(GraphTextBox.Text))
            {
                GraphTextBox.Text = graphLine;
            }
            else
            {
                GraphTextBox.Text = GraphTextBox.Text + NewLine + graphLine;
            }

            // 合計金額を表示する
            if (int.TryParse(TotalTextBox.Text, out int total))
            {
                int sum = total + price;
                TotalTextBox.Text = sum.ToString();
            }
            else
            {
                TotalTextBox.Text = price.ToString();
            }
        }

        /// <summary>
        /// アプリケーションを終了する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 買い物リストをテキストファイルとして保存する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var textDataWriter = new StreamWriter(SaveFileDialog1.FileName + ".txt", false, System.Text.Encoding.Default))
                {
                    textDataWriter.Write(ItemListTextBox.Text + NewLine + "合計金額 = " + TotalTextBox.Text);
                    textDataWriter.Close();
                }
            }
        }
    }
}