namespace Hospedaje
{
    public partial class frmcotizador : Form
    {
        public frmcotizador()
        {
            InitializeComponent();
        }

        // 1. IMPERATIVO (Tu lógica original con los operadores corrigiendo la sintaxis)
        private void btnimperactivo_Click(object sender, EventArgs e)
        {
            string Huesped = txthuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txttarifanoche.Text);

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            lstresultados.Items.Add($"[Imperativo] {Huesped} : US$ {total:N2}");
        }

        

        

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lstresultados.Items.Clear();
        }

        private void btnObjetos_Click_1(object sender, EventArgs e)
        {
            string Huesped = txthuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txttarifanoche.Text);

            Reserva reserva = new Reserva(Huesped, noches, tarifa);

            // AQUÍ PONES EL PUNTO DE INTERRUPCIÓN (F9) PARA LA PRUEBA CON EL DOCENTE
            lstresultados.Items.Add($"[Objetos] {reserva.Huesped} : US$ {reserva.Total:N2}");
        }

        private void btnFuncional_Click_1(object sender, EventArgs e)
        {
            string Huesped = txthuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txttarifanoche.Text);

            Func<int, decimal, decimal> calcSubtotal = (n, t) => n * t;
            Func<int, decimal, decimal> calcDescuento = (n, sub) => n >= 7 ? sub * 0.10m : 0m;
            Func<decimal, decimal> calcTotal = bImp => bImp + (bImp * 0.18m) + (bImp * 0.10m);

            decimal subtotal = calcSubtotal(noches, tarifa);
            decimal baseImponible = subtotal - calcDescuento(noches, subtotal);
            decimal total = calcTotal(baseImponible);

            lstresultados.Items.Add($"[Funcional] {Huesped} : US$ {total:N2}");
        }
    }

    // Clase auxiliar para la versión en Objetos
    public class Reserva
    {
        public string Huesped { get; set; }
        public int Noches { get; set; }
        public decimal TarifaPorNoche { get; set; }

        public Reserva(string huesped, int noches, decimal tarifaPorNoche)
        {
            Huesped = huesped;
            Noches = noches;
            TarifaPorNoche = tarifaPorNoche;
        }

        public decimal Subtotal => Noches * TarifaPorNoche;
        public decimal Descuento => Noches >= 7 ? Subtotal * 0.10m : 0m;
        public decimal BaseImponible => Subtotal - Descuento;
        public decimal ITBIS => BaseImponible * 0.18m;
        public decimal Servicio => BaseImponible * 0.10m;
        public decimal Total => BaseImponible + ITBIS + Servicio;
    }
}

