using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirint
{
    public partial class FrmHello : Form
    {
        public bool chit = false;

        public FrmHello()
        {
            InitializeComponent();
        }

        private void FrmHello_Load(object sender, EventArgs e)
        {
            string s = "Приветствую Вас в своей игре!\r\n";
            s+="В ней есть лабиринт, который вы должны пройти,\r\nне врезавшись в стену, не выйдя за пределы поля и не подорвавшись на бомбе.\r\n";
            s += "Попутно вы можете собирать золото и подарки.\r\nВ подарках могут быть как полезные вещи, так и опасные.\r\nЕщё у Вас есть возможность поставить на поле мину, которая через 3 секунды взорвёт предметы вокруг себя.\r\nВам урон мина не наносит. В игре есть сохранение, возможность менять образ предметов и вызова этого окна.\r\nКроме этого можно обменять 999 монет на мину, про которую уже было сказано. Эту мину можно поставить кнопкой \"ь\"\r\n";
            s+="Кнопки управления - 8, 4, 2 и 6 на цифровой клавиатуре вверх, влево, вправо и вниз соответственно.\r\nТакже есть кнопка, устанавливающая бомбу - кнопка M.\r\nУдачной игры!";
            s += "Программа разработана Мишуковым Николаем под руководством гениального преподавателя Юлии Григорьевны.";
            label1.Text = s;
        }

        private void FrmHello_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
            if (e.KeyCode == Keys.Home) { chit = true; }
        }
    }
}
