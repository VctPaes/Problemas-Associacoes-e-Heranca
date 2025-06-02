#  Problemas de POO (Associacoes e Heranca)

Biblioteca de classes em **C#** que atende aos **10 problemas** solicitados nos enunciados, sendo eles:

-  Sistema de Biblioteca com Empréstimos
-  Sistema de Cadastro Escolar com Herança
-  Plataforma de Cursos Online
-  Aplicativo de Pet Shop com Herança
-  Sistema de Vendas com Composição
-  Controle de Veículos e Manutenções
-  Sistema de Recrutamento
-  Plataforma de Streaming com Herança
-  Aplicativo de Controle de Treinos
-  Sistema de Eventos Culturais

---

##  Objetivo

Aplicar conceitos de **Programação Orientada a Objetos (POO)**, como:

-  Herança
-  Associações
-  Relacionamentos
-  Polimorfismo
-  Modelagem de classes

---

##  Estrutura do Projeto

```
/Problemas-Associacoes-e-Heranca/
│
├── Problemas_Associacoes-e-Heranca.Modelo/
│   ├── Problemas_Associacoes-e-Heranca.Console.csproj
│   ├── Program.cs
│
├── Problemas_Associacoes-e-Heranca.Modelo/
│   ├── AplicativoControleTreinos
│       ├── Aluno.cs
│       ├── Exercicio.cs
│       ├── Treino.cs
│
│   ├── AplicativoPetShop
│       ├── Animal.cs
│       ├── Cachorro.cs
│       ├── Dono.cs
│       ├── Gato.cs
│       ├── Passaro.cs
│       ├── Servico.cs
│
│   ├── BibliotecaComEmprestimos
│       ├── Emprestimo.cs
│       ├── Leitor.cs
│       ├── Livro.cs
│
│   ├── CadastroEscolar
│       ├── Aluno.cs
│       ├── Funcionario.cs
│       ├── Pessoa.cs
│       ├── Professor.cs
│
│   ├── ControleVeiculosManutencao
│       ├── Manutencao.cs
│       ├── Veiculo.cs
│
│   ├── EventosCulturais
│       ├── Evento.cs
│       ├── Oficina.cs
│       ├── Palestra.cs
│       ├── Participante.cs
│       ├── Show.cs
│
│   ├── PlataformaCursosOnline
│       ├── Aluno.cs
│       ├── Aula.cs
│       ├── Curso.cs
│       ├── Matricula.cs
│
│   ├── PlataformaStreaming
│       ├── Documentario.cs
│       ├── Episodio.cs
│       ├── Filme.cs
│       ├── Midia.cs
│       ├── Serie.cs
│
│   ├── SistemaRecrutamento
│       ├── Candidato.cs
│       ├── Candidatura.cs
│       ├── Vaga.cs
│
│   ├── SistemaVendas
│       ├── ItemPedido.cs
│       ├── Pedido.cs
│       ├── Produto.cs
│
├── .gitattributes
├── LICENSE
├── Problemas-Associacoes-e-Heranca.sln
├── README.md
```

---

##  Conceitos Aplicados

- **Associações:**  
   Relacionamentos entre **objetos**, como:

   - Um `Aluno` possui vários `Treinos`.
   - Um `Pedido` contém múltiplos `ItemPedido`.
   - Um `Participante` pode se inscrever em vários `Evento` e vice-versa.

- **Herança**  
   **Superclasses** abstratas são especializadas por **subclasses**, permitindo o reaproveitamento de atributos e métodos comuns.

- **Polimorfismo**  
   Métodos sobrescritos em **subclasses**, permitindo tratamento uniforme de diferentes tipos de **objetos**.

- **Composição**  
   **Objetos** que só existem dentro do contexto de outro.

- **Encapsulamento**
   Atributos protegidos e coleções expostas apenas para leitura (`IReadOnlyCollection<T>` ou propriedades `private set`), garantindo integridade dos dados e acesso controlado.

---

##  Validações Implementadas

-  **Sistema Biblioteca:** Impedem empréstimo de livro já emprestado.
-  **Aplicativo Petshop:** Restringe certos serviços apenas para cachorros.
-  **Sistema de Vendas:** Calculo automático do valor do total do pedido, sendo atualizado sempre que itens forem adicionados, removidos ou modificados.
-  **Controle de Veículos e Manutenções:** Não permite duas manutenções no mesmo veículo na mesma data.
-  **Aplicativo Controle de Treinos:** Permite a edição dos detalhes de cada exercício e calcula a carga total do treino somando os produtos de séries, repetições e pesos de todos os exercícios.

---

##  Autores

**Laura Kauana Bareto**   
email: laurabareto@alunos.utfpr.edu.br

**Victor Luiz de Oliveira Paes**   
email: victorpaes@alunos.utfpr.edu.br
