namespace CheckPoint1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CHECKPOINT 1 - FUNDAMENTOS C# - Turma  3ESPY ===\n");

        // ENTREGA ATÉ DIA 08/09 AS 23:59
        // NOME: MARIA JULIA ARAUJO RODRIGUES - 3ESPR
        // RM: 553384
        // Você deve criar um repositório público ou branch no github e me enviar o link pelo
        // teams antes do fim do prazo.
        // IMPORTANTE:
        // - Não haverá reposição do checkpoint.
        // - Fique atento ao prazo, nenhum trabalho será aceito após a data e vou me basear
        // - O link do seu git deve ser enviado no teams. A data e hora do recebimento do git será utilizada para verificar se foi enviado no prazo.


        
        
        Console.WriteLine("1. Testando DemonstrarTiposDados...");
        Console.WriteLine(DemonstrarTiposDados());

        Console.WriteLine("\n2. Testando CalculadoraBasica (SWITCH)...");
        Console.WriteLine(CalculadoraBasica(10, 5, '+')); 
        Console.WriteLine(CalculadoraBasica(10, 0, '/'));  
        Console.WriteLine(CalculadoraBasica(10, 5, '?'));

        Console.WriteLine("\n3. Testando ValidarIdade (IF/ELSE)...");
        Console.WriteLine(ValidarIdade(25));

        Console.WriteLine("\n4. Testando ConverterString...");
        Console.WriteLine(ConverterString("123", "int"));  
        Console.WriteLine(ConverterString("true", "bool"));

        Console.WriteLine("\n5. Testando ClassificarNota (SWITCH)...");
        Console.WriteLine(ClassificarNota(8.5));

        Console.WriteLine("\n6. Testando GerarTabuada (FOR)...");
        Console.WriteLine(GerarTabuada(5));

        Console.WriteLine("\n7. Testando JogoAdivinhacao (WHILE)...");
        Console.WriteLine(JogoAdivinhacao(50, new int[]{25, 75, 50}));

        Console.WriteLine("\n8. Testando ValidarSenha (DO-WHILE)...");
        Console.WriteLine(ValidarSenha("MinhaSenh@123"));

        Console.WriteLine("\n9. Testando AnalisarNotas (FOREACH)...");
        Console.WriteLine(AnalisarNotas(new double[]{8.5, 7.0, 9.2, 6.5, 10.0}));

        Console.WriteLine("\n10. Testando ProcessarVendas (FOREACH múltiplo)...");
        double[] vendas = { 1000, 500, 300, 2000, 800 };
        string[] categorias = { "A", "B", "C", "A", "B" };
        double[] comissoes = { 0.10, 0.07, 0.05 };
        string[] nomesCategorias = { "A", "B", "C" };
        Console.WriteLine(ProcessarVendas(vendas, categorias, comissoes, nomesCategorias));

        Console.WriteLine("\n=== RESUMO: TODAS AS ESTRUTURAS FORAM TESTADAS ===");
        Console.WriteLine("✅ IF/ELSE: Testado na validação de idade");
        Console.WriteLine("✅ SWITCH: Testado na calculadora e classificação de notas");
        Console.WriteLine("✅ FOR: Testado na tabuada");
        Console.WriteLine("✅ WHILE: Testado no jogo de adivinhação");
        Console.WriteLine("✅ DO-WHILE: Testado na validação de senha");
        Console.WriteLine("✅ FOREACH: Testado na análise de notas e processamento de vendas");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // =====================================================================
    // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Complete o método para demonstrar diferentes tipos de dados
    /// - Declare uma variável de cada tipo primitivo (int, double, bool, char, string)
    /// - Use inferência de tipos (var) onde apropriado
    /// - Retorne uma string concatenando todos os valores
    /// </summary>
    private static string DemonstrarTiposDados()
    {
        int inteiro = 42;
        double decimalNum = 3.14;
        bool booleano = true;
        char caractere = 'A';
        string texto = "Olá";

        // usando var 
        var outroInteiro = 100;

        return $"Inteiro: {inteiro}, Decimal: {decimalNum}, Booleano: {booleano}, Caractere: {caractere}, Texto: {texto}, OutroInteiro: {outroInteiro}";
    }


    // =====================================================================
    // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Implemente uma calculadora básica usando SWITCH
    /// - Receba dois números e um operador (+, -, *, /)
    /// - Use SWITCH para selecionar a operação
    /// - Trate divisão por zero retornando 0
    /// - Para operadores inválidos, retorne -1
    /// </summary>
    private static double CalculadoraBasica(double num1, double num2, char operador)
    {
        switch (operador)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num2 != 0 ? num1 / num2 : 0; // evita divisão por zero
            default:
                return -1; // operador inválido
        }
    }


    // =====================================================================
    // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)  
    // =====================================================================

    /// <summary>
    /// TODO: Valide se uma idade é válida para diferentes contextos usando IF/ELSE
    /// - Use IF/ELSE encadeados (não switch)
    /// - Retorna "Criança" se idade < 12
    /// - Retorna "Adolescente" se idade >= 12 e < 18  
    /// - Retorna "Adulto" se idade >= 18 e <= 65
    /// - Retorna "Idoso" se idade > 65
    /// - Retorna "Idade inválida" se idade < 0 ou > 120
    /// Use operadores relacionais e lógicos
    /// </summary>
    private static string ValidarIdade(int idade)
    {
        if (idade < 0 || idade > 120)
            return "Idade inválida";
        else if (idade < 12)
            return "Criança";
        else if (idade >= 12 && idade < 18)
            return "Adolescente";
        else if (idade >= 18 && idade <= 65)
            return "Adulto";
        else
            return "Idoso";
    }


    // =====================================================================
    // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Converta uma string para diferentes tipos
    /// - Tente converter 'valor' para int, double e bool
    /// - Se a conversão for bem-sucedida, retorne "Tipo: Valor convertido"
    /// - Se falhar, retorne "Conversão impossível para [tipo]"
    /// - Use TryParse para conversões seguras
    /// </summary>
    private static string ConverterString(string valor, string tipoDesejado)
    {
        switch (tipoDesejado.ToLower())
        {
            case "int":
                if (int.TryParse(valor, out int intResultado))
                    return $"Int: {intResultado}";
                else
                    return "Conversão impossível para int";

            case "double":
                if (double.TryParse(valor, out double doubleResultado))
                    return $"Double: {doubleResultado}";
                else
                    return "Conversão impossível para double";

            case "bool":
                if (bool.TryParse(valor, out bool boolResultado))
                    return $"Bool: {boolResultado}";
                else
                    return "Conversão impossível para bool";

            default:
                return "Tipo inválido (use: int, double ou bool)";
        }
    }


    // =====================================================================
    // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Classifique uma nota usando switch expression (C# 8+) ou switch tradicional
    /// - 9.0 a 10.0: "Excelente"
    /// - 7.0 a 8.9: "Bom" 
    /// - 5.0 a 6.9: "Regular"
    /// - 0.0 a 4.9: "Insuficiente"
    /// - Fora da faixa: "Nota inválida"
    /// </summary>
    private static string ClassificarNota(double nota)
    {
        switch (nota)
        {
            case >= 9.0 and <= 10.0:
                return "Excelente";
            case >= 7.0 and < 9.0:
                return "Bom";
            case >= 5.0 and < 7.0:
                return "Regular";
            case >= 0.0 and < 5.0:
                return "Insuficiente";
            default:
                return "Nota inválida";
        }
    }


    // =====================================================================
    // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOR
    /// Gere a tabuada de um número de 1 a 10
    /// - Use FOR para iterar de 1 a 10
    /// - Retorne string formatada: "2 x 1 = 2\n2 x 2 = 4\n..." 
    /// - Se número for <= 0, retorne "Número inválido"
    /// </summary>
    private static string GerarTabuada(int numero)
    {
        if (numero <= 0)
            return "Número inválido";

        string resultado = "";

        for (int i = 1; i <= 10; i++)
        {
            resultado += $"{numero} x {i} = {numero * i}\n";
        }

        return resultado;
    }


    // =====================================================================
    // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR WHILE
    /// Simule um jogo de adivinhar número com tentativas limitadas
    /// - numeroSecreto: número a ser adivinhado (1-100)
    /// - tentativas: array com os palpites do jogador
    /// - Use WHILE para percorrer as tentativas
    /// - Para cada tentativa: "Tentativa X: muito alto/baixo/correto"
    /// - Pare no acerto ou quando acabar as tentativas
    /// - Retorne string com histórico completo
    /// </summary>
    private static string JogoAdivinhacao(int numeroSecreto, int[] tentativas)
    {
        string resultado = "";
        int i = 0;

        while (i < tentativas.Length)
        {
            int palpite = tentativas[i];
            resultado += $"Tentativa {i + 1}: {palpite} - ";

            if (palpite == numeroSecreto)
            {
                resultado += "correto!\n";
                break; // para no acerto
            }
            else if (palpite < numeroSecreto)
            {
                resultado += "muito baixo\n";
            }
            else
            {
                resultado += "muito alto\n";
            }

            i++;
        }

        return resultado;
    }


    // =====================================================================
    // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR DO-WHILE
    /// Valide uma senha seguindo critérios de segurança
    /// - A senha deve ter pelo menos 8 caracteres
    /// - Deve ter pelo menos 1 número
    /// - Deve ter pelo menos 1 letra maiúscula  
    /// - Deve ter pelo menos 1 caractere especial (!@#$%&*)
    /// - Use DO-WHILE para verificar cada critério
    /// - Retorne string explicando quais critérios não foram atendidos
    /// - Se senha válida, retorne "Senha válida"
    /// </summary>
    private static string ValidarSenha(string senha)
    {
        string erros = "";
        int i = 0;

        bool temNumero = false;
        bool temMaiuscula = false;
        bool temEspecial = false;
        string especiais = "!@#$%&*";

        // Critério 1: tamanho
        if (senha.Length < 8)
            erros += "A senha deve ter pelo menos 8 caracteres\n";

        // Critérios restantes usando DO-WHILE
        do
        {
            char c = senha[i];

            if (char.IsDigit(c))
                temNumero = true;

            if (char.IsUpper(c))
                temMaiuscula = true;

            if (especiais.Contains(c))
                temEspecial = true;

            i++;
        } while (i < senha.Length);

        if (!temNumero)
            erros += "A senha deve ter pelo menos 1 número\n";

        if (!temMaiuscula)
            erros += "A senha deve ter pelo menos 1 letra maiúscula\n";

        if (!temEspecial)
            erros += "A senha deve ter pelo menos 1 caractere especial (!@#$%&*)\n";

        return string.IsNullOrEmpty(erros) ? "Senha válida" : erros.Trim();
    }


    // =====================================================================
    // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH
    /// Analise um array de notas de alunos
    /// - Use FOREACH para percorrer todas as notas
    /// - Calcule: média, quantidade de aprovados (>=7), maior nota, menor nota
    /// - Conte quantas notas estão em cada faixa: A(9-10), B(8-8.9), C(7-7.9), D(5-6.9), F(<5)
    /// - Retorne string formatada com todas as estatísticas
    /// - Se array vazio/null: "Nenhuma nota para analisar"
    /// </summary>
    private static string AnalisarNotas(double[] notas)
    {
        if (notas == null || notas.Length == 0)
            return "Nenhuma nota para analisar";

        double soma = 0;
        int aprovados = 0;
        double maior = double.MinValue;
        double menor = double.MaxValue;

        // contadores das faixas
        int faixaA = 0, faixaB = 0, faixaC = 0, faixaD = 0, faixaF = 0;

        foreach (double nota in notas)
        {
            soma += nota;

            if (nota >= 7.0)
                aprovados++;

            if (nota > maior)
                maior = nota;

            if (nota < menor)
                menor = nota;

            if (nota >= 9.0 && nota <= 10.0)
                faixaA++;
            else if (nota >= 8.0 && nota < 9.0)
                faixaB++;
            else if (nota >= 7.0 && nota < 8.0)
                faixaC++;
            else if (nota >= 5.0 && nota < 7.0)
                faixaD++;
            else
                faixaF++;
        }

        double media = soma / notas.Length;

        return $"Média: {media:F1}\n" +
               $"Aprovados: {aprovados}\n" +
               $"Maior: {maior:F1}\n" +
               $"Menor: {menor:F1}\n" +
               $"A: {faixaA}, B: {faixaB}, C: {faixaC}, D: {faixaD}, F: {faixaF}";
    }


    // =====================================================================
    // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH (múltiplos)
    /// Processe vendas por categoria e calcule comissões
    /// - vendas: array com valores de vendas
    /// - categorias: array com categorias correspondentes ("A", "B", "C")
    /// - comissoes: array com percentuais de comissão por categoria (ex: A=10%, B=7%, C=5%)
    /// - Use FOREACH para percorrer vendas e categorias simultaneamente
    /// - Use FOREACH separado para encontrar a comissão da categoria
    /// - Calcule total de vendas e total de comissões por categoria
    /// - Retorne string com relatório detalhado
    /// </summary>
    private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
    {
        if (vendas == null || categorias == null || comissoes == null || nomesCategorias == null)
            return "Dados inválidos";

        if (vendas.Length != categorias.Length)
            return "O número de vendas deve ser igual ao número de categorias";

        // Totais por categoria
        Dictionary<string, double> totalVendas = new Dictionary<string, double>();
        Dictionary<string, double> totalComissoes = new Dictionary<string, double>();

        // Inicializa os totais
        for (int i = 0; i < nomesCategorias.Length; i++)
        {
            totalVendas[nomesCategorias[i]] = 0;
            totalComissoes[nomesCategorias[i]] = 0;
        }

        int index = 0;
        foreach (double venda in vendas)
        {
            string categoria = categorias[index];
            double percentual = 0;

            // Busca comissão correspondente usando outro FOREACH
            int j = 0;
            foreach (string nomeCat in nomesCategorias)
            {
                if (nomeCat == categoria)
                {
                    percentual = comissoes[j];
                    b


    // =====================================================================
    // MÉTODOS AUXILIARES (NÃO ALTERAR - APENAS PARA REFERÊNCIA)
    // =====================================================================

                    /// <summary>
                    /// Método de exemplo demonstrando diferença entre estático e de instância
                    /// ESTÁTICO: Pertence à classe, não precisa criar objeto para usar
                    /// </summary>
    private static void ExemploMetodoEstatico()
    {
        Console.WriteLine("Sou um método estático - chamado direto da classe");
    }

    /// <summary>
    /// Método de exemplo de instância (comentado pois não pode ser chamado do Main estático)
    /// DE INSTÂNCIA: Pertence ao objeto, precisa criar instância da classe
    /// </summary>
    /*
    void ExemploMetodoInstancia()
    {
        Console.WriteLine("Sou um método de instância - preciso de um objeto para ser chamado");
    }
    */
}