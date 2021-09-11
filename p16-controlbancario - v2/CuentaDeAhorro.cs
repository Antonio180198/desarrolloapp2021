namespace p15_controlbancario{
    public class CuentaDeAhorro : CuentaBancaria{

        public CuentaDeAhorro(float saldo,float intereses) : base(saldo){
            this.intereses=intereses;
        }
        public float intereses{get; private set;}

        public void CalcularInteres(){
            saldo += (saldo*intereses);
        }
    }
}