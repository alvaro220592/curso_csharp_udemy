using System;
using System.Globalization;

namespace Aluno{
    class Aluno{
        public double N1, N2, N3, Media;
        public double NotaMinima = 60;
        public string Resultado;

        public void CalcMedia(){
            this.Media =  (N1 + N2 + N3) / 3;
        }

        public void CalcResultado(){
            if(this.Media >= this.NotaMinima){
                this.Resultado = "Aprovado";
            }else{
                this.Resultado = "Reprovado";
            }
        }

        public override string ToString()
        {
            if(this.Resultado != "Aprovado"){
                return $"{this.Resultado}. Faltaram {(this.NotaMinima - this.Media).ToString("F2", CultureInfo.InvariantCulture)} pontos para sua aprovação.";
            }else{
                return $"{this.Resultado}.";
            }
        }
    }
}