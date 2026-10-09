namespace Hospedaje
{
    public partial class frmcotizador : Form
    {
        public frmcotizador()
        {
            InitializeComponent();
        }


        private void btnimperativo_Click(object sender, EventArgs e)
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

        private void btncopiar_Click(object sender, EventArgs e)
        {
            // 1. Construir el texto con el desglose completo de la cotización
            string mensajeWhatsapp = $"*Cotización Villa Coral*\n" +
                                     $"Huésped: {txthuesped.Text}\n" +
                                     $"Noches: {nudNoches.Value}\n" +
                                     $"Subtotal: {lblresultadosubtotal.Text}\n" +
                                     $"Descuento: {lblresultadodescuento.Text}\n" +
                                     $"ITBIS (18%): {lblresultadoitbis.Text}\n" +
                                     $"Servicio (10%): {lblresultadoservicio.Text}\n" +
                                     $"*TOTAL USD: {lblresultadototal.Text}*";

            // 2. Copiar todo el contenido al portapapeles
            Clipboard.SetText(mensajeWhatsapp);

            // 3. Mostrar el aviso en pantalla
            MessageBox.Show("cotizacion copiada al portapapeles",
                            "Copiado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lstresultados.Items.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string Huesped = txthuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txttarifanoche.Text);

            
            if (checkBox1.Checked)
            {
                tarifa *= 1.25m;
            }

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

            
            lblresultadocotizacion.Text = total.ToString("N2");
            lblresultadosubtotal.Text = subtotal.ToString("N2");
            lblresultadodescuento.Text = descuento.ToString("N2");
            lblresultadoitbis.Text = itbis.ToString("N2");
            lblresultadoservicio.Text = servicio.ToString("N2");
            lblresultadototal.Text = total.ToString("N2");

            
            lstresultados.Items.Add($"[Cotización] {Huesped} : US$ {total:N2}");
        }
    }

    
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

