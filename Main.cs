using MultiLangSample.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace MultiLangSample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var locales = new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("ja-JP", "日本語"),
                new KeyValuePair<string, string>("en-US", "英語")
            };

            // コンボボックスに KeyValuePair をバインドする
            comboBox1.DataSource = locales;
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // リソースファイルからラベル文字列を取得
            label1.Text = Resources.Greeting;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リソースファイルのカルチャーを変更する
            var selected = (KeyValuePair<string, string>)comboBox1.SelectedItem;
            Resources.Culture = new CultureInfo(selected.Key);

            // リソースファイルからラベル文字列を取得
            label1.Text = Resources.Greeting;
        }
    }
}
