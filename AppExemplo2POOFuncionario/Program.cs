using AppExemplo2POOFuncionario.Model;

Funcionario funcionario = new Funcionario();

Console.WriteLine("Informe o nome do funcionário");
funcionario.nome = Console.ReadLine();

Console.WriteLine("Informe a idade do funcionário");
funcionario.idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o sexo do funcionário");
funcionario.sexo = Console.ReadLine();

Console.WriteLine("Informe o salário do funcionário");
funcionario.salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("Dados do Funcionário");
Console.WriteLine("");
Console.WriteLine($"Nome do Funcionário: {funcionario.nome}\r\n" +
                  $"Idade do Funcionário: {funcionario.idade}\r\n" +
                  $"Sexo do Funcionário: {funcionario.sexo}\r\n" +
                  $"Salário do Funcionário: R$ {funcionario.salario}");
Console.WriteLine("");
Console.WriteLine("Dados financeiros do Funcionário");
Console.WriteLine(""); 
Console.WriteLine("Informe os meses trabalhados para o calculo do Décimo Terceiro Salário");
int mesesTrabalhados = Convert.ToInt32(Console.ReadLine());
double decimoTerceiro = funcionario.CalcularDecimoTerceiro(mesesTrabalhados);
Console.WriteLine($"O valor do Décimo Terceiro Salário é R$ {decimoTerceiro}");
Console.WriteLine("");  
funcionario.CalcularFerias();