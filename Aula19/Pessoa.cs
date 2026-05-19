namespace Aula19{

    public class Pessoa {

        // Atributos
        public string Nome;
        public int Idade;

        // Métodos
        public bool Maioridade(int Idade){

            if (Idade >= 18){

                return true;
            }
            else{

                return false;
            }
        }
    }
}