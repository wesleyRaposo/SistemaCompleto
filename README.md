# Projeto: Sistema Completo ![icons8-módulo-48](https://user-images.githubusercontent.com/50245831/215336291-89542dc0-41b4-4d9b-b4e4-5e250c7e3092.png)

![Badge em Desenvolvimento](https://img.shields.io/badge/Visual%20Studio-Microsoft-blue)
![Badge LocalDB](https://img.shields.io/badge/Database-LocalDB-orange)
![GitHub Org's stars](https://img.shields.io/github/stars/wesleyRaposo?style=social)

Esse projeto é um exercício de C# com Windows Forms, aplicando vários conhecimentos sobre a linguagem.  
Seu intuito é ser uma fonte educativa para iniciantes na linguagem C#, principalmente para os "migrantes" de linguagens voltadas para soluções desktop.

# Tecnologias envolvidas:

Linguagem: ```C#```  
Ferramenta de desenvolvimento: ```Visual Studio 2019 Community```  

# Técnicas para aprendizagem:

```Windows Forms```  
```Classes em C#```  
```Herança de classes```  
```Herança de Forms```  
```Ocultação de construtores```  
```Criação de construtores especializados```  
```Acesso à base de dados externa```  
```CRUD```  
```Estruturação de solucion em múltiplos projetos```  


# Autor:

| [<img src="https://avatars.githubusercontent.com/u/50245831?v=4" width=115><br><sub>Wesley Raposo</sub>](https://github.com/wesleyRaposo) 
| :---: |


# Licença

Este código foi publicado apenas para fins de estudo de programadores iniciantes na linguagem C# com Visual Studio.  
Sua finalidade é exclusivamente acadêmica.  


# Apresentação

O objetivo desse mini projeto é dar aos programadores que estejam migrando de alguma linguagem voltada para desktop (como o Delphi) para C# uma referência mínima do uso da linguagem C# em uma aplicação desktop, que já é familiar a estes programadores.

Para quem é "delpheiro", um alerta: tanto a framework quanto os componentes disponibilizados para Windows Forms são inferiores ao Delphi em vários aspectos.
E não me refiro à última versão do Delphi (que nem sei qual é). Refiro-me à boa e velha VCL e as paletas de componentes disponíveis no velhino, mas ainda funcional, "Delphi 7".

Liste abaixo os pontos que mais me chamaram a atenção no que considero uma inferioridade do Visual Studio quando o assunto é programção desktop, mas com certeza vocês perceberão outras coisas:
- Quantidade pequena de compontentes nativos (comparado ao Delphi, a diferença é gritante).
- A herança de formulários é bastante instável, devendo ser usada com muito cuidado. Em alguns casos o form para de renderizar sem nenhuma explicação aparente!
  > Nesses casos, o ideal é limpar a solução, fechar o Visual Studio e reabrí-lo, torcendo para voltar a renderizar.
  > A solução nativa de herança não fica sempre disponível. Em alguns casos, você tem que forçar a herança "no braço", como foi o caso deste projetinho.
- Não existe uma estruturação de projeto MVC nativa para programção desktop. Faça a sua do seu jeito.
  > Ok, o Delphi também NÃO tinha. Mas quem migra pro Visual Studio tem alta expectativa em relação à ferramenta e pode se decepcionar um pouco.  
 
Para os "delpheiros", disponibilizei nesse projeto as seguintes implementações para serem estudadas:
- Solução distribuída em diferentes projetos (exemplo de estruturação de uma solution);
- Formulários distribuídos em pastas conforme a função (exemplo de organização de fontes);
- Formulário principal cujas opções de menu usam imagens contidas em arquivo de recurso (disponível no projeto "SistemaPrincipal" - exemplo de uso de arquivo de recursos);
- Herança de formulários (FrmBase -> formulários filhos);
                         (FrmBase -> FrmBaseCRUD -> formulários filhos);
- Exemplo de uso de componente "timer" (no formulário principal);
- Exemplo de uso de "progress bar" (no formulário principal);
- Exemplo de uso de interfaces (aplicado aos FrmBase e FrmBaseCRU - não são o melhor exemplo do uso de interface na orientação a objetos mas mostram como aplicá-la a uma classe. O arquivo "IClasseBase.cs" também contém uma interface aplicada diretamente à "ClassesBase.cs".);
- Exemplo de como incluir arquivos não compiláveis no projeto (as imagens foram incluídas no projeto por fazer parte dele e aparecem no gerenciador de soluções e são visíveis para o Git, mas não são utilizadas diretamente. As imagens em uso estão no arquivo de recuros).
- Exemplo de uso de "funções" de forma similar ao Delphi. O C# não tem esse recurso, mas você pode construir uma classe estática e colocar nela diversas funções úteis à sua programação e que não estão disponíveis em objetos (e nem precisam estar). Veja o arquivo "Funcoes.cs".
- Exemplo de um tipo enumerado (ver arquivo "EnumTipoOperacao.cs").
- Exemplo de uso de base de dados. No caso, o projeto utiliza uma base de dados local, para não depender de nenhum SGDB externo (ver projeto "CabadaDeConexao").
- Exemplo de MVC. Esse não é o padrão de programação desktop adotado pela comunidade C# mas é uma forma de fazê-lo (similar a uma maneira com a qual trabalhei em Delphi há mais de 15 anos).
  Ele está estruturado da seguinte forma:
  > O formulário FrmUsuario (no projeto "SistemaPrincipal") é a o "view";
  > O formulário se comunica com a classe "ControleUsuario", que é o controller (no projeto "RegrasDeNegocio");
  > A classe "ControleUsuario" se comunica com os modelos que, no caso, é a classe "Usuario" (no projeto "CamadaDeDados");
    O controller também se comunica com a camada de conexão (no projeto "CamadaDeConexao"), com as funções utilitárias e o que demais for necessário;
- Exemplo do uso do arquivo "App.config". Nesse projeto ele carrega a configuração de acesso à base de dados, que deixa de ser hardcode e passa a ser contida num arquivo editável.  

Em minha época de "delpheiro" (na verdade ainda mexo com a ferramenta) eu também trabalhava com uma classes "gerente" no nosso MVC, que era uma classe de negócio responsável por conectar diferentes controladores e/ou diferentes modelos, ou seja, fazia um encapsulamento de regras de negócio mais complexas. Esse projetinho não contempla esse tipo de implementação, pois seu modesto objetivo é apenas lançar uma base referencial para quem conhece muito pouco ou nada da linguagem C#.

# Status:

> :construction: Em construção :construction:
