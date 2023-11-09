using System;




public class Pessoa
{
protected String? Nome { get; set; }

}

public class PessoaFisica:Pessoa
{

    public PessoaFisica(string nome)
    {
        this.Nome=nome;

        NomeFisico=Nome;

        Random r=new Random();

        
        int Pontuacao=0;//Define a aparição dos '.' no array.
        int Traco=0;//define a aparição unica do traço '-' no array.
        string[] AleatorioCpf=new string[14];

        for (int i = 0; i <AleatorioCpf.Length; i++)
        {int a=0;
           
           Pontuacao++;
            if(i==11)
            {
                AleatorioCpf[i]="-";
                Traco=1;
                a=1;
            }

            if(Pontuacao==4 && Traco==0)
            {
                AleatorioCpf[i]=".";
                Pontuacao=0;
            }
            else if(a==0)
            {
                 AleatorioCpf[i]=r.Next(0,9).ToString();
            }

           
            
        }

        string? Ab="";

        foreach (var item in AleatorioCpf)
        {
            Ab+=item;
        }
        this.Cpf=Ab;

    }
    private string? Cpf { get; set; }
    private string? NomeFisico { get; set; }



    public string GetCpf()
    {
        return Cpf!;
    }

    public string GetNome()
    {
        return NomeFisico!;
    }
}

public class PessoaJuridica:Pessoa
{
    public PessoaJuridica()
    {
        Random r=new Random();

        int Pontuacao=0;//Define a aparição dos '.' no array.

        int Travessao=0;//define a aparição unica do travessao '/' no array.

        string[] AleatorioCnpj=new string[18];

        for (int i = 0; i <AleatorioCnpj.Length; i++)
        {
            int a=0;
           //Modelo cnpj:XX.XXX.XXX/0001-XX.
           Pontuacao++;
            if(i==10)
            {
                AleatorioCnpj[i]="/";
                Travessao=1;
                a=1;

                for (int j = 11; j < 16; j++)
                {
                    AleatorioCnpj[j]="0";
                    if(j==15)
                    {
                        AleatorioCnpj[j]="-";
                    }

                    if(j==14)
                    {
                        AleatorioCnpj[j]="1";
                    }
                    i++;

                }
            }

            if(i==2 || Pontuacao==4 && Travessao==0)
            {
                AleatorioCnpj[i]=".";
                Pontuacao=0;
            }
            else if(a==0)
            {
                 AleatorioCnpj[i]=r.Next(0,9).ToString();
            }

           
            
        }

        string? Ab="";

        foreach (var item in AleatorioCnpj)
        {
            Ab+=item;
        }

        this.Cnpj=Ab;
    }

    private string? Cnpj { get; set; }
    private string? RazaoSocial { get; set; }
    private string? NomeFantasia { get; set; }


    public string? GetCnpj()
    {
        return Cnpj;
    }

    public string? GetRazaoSocial()
    {
        string? NomeAleatorio="";
        Random r=new Random();

        int RS=r.Next(1,3);



        switch(RS)
        {
            case 1:
                NomeAleatorio="Louças Brasil LTDA";
            break;

            case 2:
                NomeAleatorio="General Carros do Brasil S.A";
            break;

            case 3:
                NomeAleatorio="Cuca Cola Indústrias Ltda";
            break;
        }

        this.RazaoSocial=NomeAleatorio;

        return RazaoSocial;
    }

     public string? GetNomeFantasia(string RS)
    {
        string? NomeAleatorio="";
        



                if(RS=="Louças Brasil LTDA")
                NomeAleatorio="BomBrilho.";
            

                if(RS=="General Carros do Brasil S.A")
                NomeAleatorio="Chavrolet.";
            
                if(RS=="Cuca Cola Indústrias Ltda")
                NomeAleatorio="Cuca Cola.";
        

        this.NomeFantasia=NomeAleatorio;

        return NomeFantasia;
    }


}

class GitTeste
{

    static void Main(string[] args)
    {   

        string? NomeAleatorio="";
        Random r=new Random();

        int Escolha=r.Next(1,3);



        switch(Escolha)
        {
            case 1:
                NomeAleatorio="Alberto M. Ferreira";
            break;

            case 2:
                NomeAleatorio="Astolfo F. Machado";
            break;

            case 3:
                NomeAleatorio="Vitor A. Santos";
            break;
        }

        PessoaFisica pf=new PessoaFisica(NomeAleatorio!);

        string Cpf=pf.GetCpf();
        string Nome=pf.GetNome();

        Console.WriteLine($"\nNome: {Nome}/CPF:{Cpf}\n");

        PessoaJuridica pj=new PessoaJuridica();

        string? Cnpj=pj.GetCnpj();
        string? RS=pj.GetRazaoSocial();
        string? NF=pj.GetNomeFantasia(RS!);

        Console.WriteLine($"-Razão sócial da pessoa juridica: {RS}\n-Nome fantasia: {NF}\n-CNPJ:{Cnpj}.\n");
    }


}
//Programa para rosangela no GIT e corrigida no VScode.




/*O programa Visa criar uma classe chamada Pessoa que tenha como atributo protegido o nome da pessoa. Em seguida, crie duas outras
classes chamadas PessoaFisica e PessoaJuridica que herdem da classe Pessoa. A classe PessoaFisica terá como
atributos privados o CPF e o nome da pessoa, enquanto a classe PessoaJuridica terá como atributos privados o
CNPJ, a razão social e o nome fantasia. Crie métodos get e set para todos os atributos das três classes.
*/
