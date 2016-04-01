using ClashOfClans_Consultas.Modelos;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClashOfClans_Consultas.API;

namespace ClashOfClans_Consultas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            consultarClan();
        }

        private void consultarClan()
        {
            ClashOfClans coc = new ClashOfClans();

            Clan clan = coc.buscarClanPorTag("#8CQRGV28");
            //Clanes clanes = coc.buscarClanPorNombre("KICK ASS");
            //MiembrosClan miembros = coc.consultarMiembrosClan("#8CQRGV28");
            //Localidades localidades = coc.

        }
    }
}
