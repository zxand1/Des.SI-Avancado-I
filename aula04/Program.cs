class Program {
  public static void Main(string[] args){
    Pessoa objPessoa = new Pessoa("Xandão Sensacional");
    Console.WriteLine("Antes do método (Classe):" + objPessoa.ToString());

    PessoaStruct objPessoaStruct = new PessoaStruct("Xandão Sensacional");
    Console.WriteLine("Antes do método (Struct):" + objPessoaStruct.ToString());
    
    UpdateNameClass(objPessoa);
    Console.WriteLine("Depois do método (Classe): " + objPessoa.ToString());

    UpdateNameStruct(objPessoaStruct);
    Console.WriteLine("Depois do método (Struct): " + objPessoaStruct.ToString());
  }
  public static void UpdateNameClass(Pessoa objAux){
    objAux.Nome = "Carol";
  }
  public static void UpdateNameStruct(PessoaStruct objAux){
    objAux.NomeStruct = "Carol";
  }
}