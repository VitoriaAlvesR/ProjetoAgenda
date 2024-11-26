using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    //Transformação da classe em pública, para que todos possam utilizar, tranformando-á também em estática, para com a qual todos utilizam a mesma classe (o mesmo Paulo).
    //Se a minha classe é "STATIC" Todos que estão dentro dela deverão ser "STATIC".
    public static class UserSession
    {
        //Variavés que guardam as informações do usuário logado.
        private static string _usuario = null;
        private static string _senha = null;
        private static string _nome = null;
        
        // Encapsulamento da variável, para o qual tenha controle do que será inserido ou "pego"
        //Guardando o usuário.
        public static string usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                //Colocando as letras em maiúsculas
                //value = value.ToUpper();
                _usuario = value;

                //Comando para usar uma nova pasta
                //using "nome do meu projeto".Nome da pasta

                //Comando para aparecer o que foi escrito na textBox1
                //USerSession.usuario = TextBox1.Text;

                //Comando para visualizar quem escreveu
                //MessageBox.Show(UserSession.usuario)
            }
        }
        public static string senha
        {
            get
            {
                return _senha;
            }

            set
            {
                _senha = value;
            }
        }

        public static string nome
        {
            get
            {
                return _nome;
            }

            set
            {
                value = value.ToLower();
                _nome = value;

            }
        }
    }
}
