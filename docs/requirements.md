# 📘 **Descrição do Novo Sistema *SmartSchoolMZ***

A instituição de ensino em estudo é uma organização privada que se encontra actualmente na fase de criação e regulamentação, com o objectivo de actuar na área de educação, abrangendo o ensino da 1ª à 12ª Classe. Diferentemente de muitas instituições que apenas informatizam os seus processos após o início das suas actividades, esta instituição pretende iniciar as suas operações já com um Sistema de Informação Computarizado para a Gestão Escolar, garantindo desde o início maior organização, controlo, eficiência e autonomia dos seus utilizadores.

O sistema será responsável pela gestão integrada de alunos, professores, encarregados de educação, turmas, disciplinas, avaliações, frequência e pagamentos, permitindo não só a automatização dos processos internos, mas também a redução da dependência dos alunos e encarregados em relação aos serviços presenciais da escola.

Para o funcionamento do sistema, todos os intervenientes terão acesso através de autenticação segura, com permissões específicas de acordo com o seu perfil, nomeadamente administrador, professor, aluno e encarregado de educação.

No início das actividades, o administrador será responsável pelo registo dos utilizadores, efectuando o cadastro dos alunos, professores e encarregados de educação, recolhendo os dados necessários para a sua identificação e contacto. De seguida, procederá à configuração da estrutura académica, criando o ano lectivo, definindo as classes, organizando as turmas e cadastrando as disciplinas, bem como a atribuição das mesmas aos respectivos professores.

Após o cadastro dos alunos, estes serão associados aos seus encarregados de educação, que passam a ser responsáveis pelo seu acompanhamento. Para que o aluno possa frequentar as aulas, é efectuado o processo de matrícula, que consiste na sua integração numa turma específica dentro de um determinado ano lectivo, estabelecendo assim o seu vínculo com a instituição.

Durante o decorrer do ano lectivo, os professores serão responsáveis pelo registo das notas dos alunos no sistema, de acordo com os diferentes momentos de avaliação, tais como testes, trabalhos e exames. O sistema permitirá o processamento automático dessas informações, facilitando o cálculo das médias e a avaliação do desempenho académico.

Paralelamente, será efectuado o controlo da frequência dos alunos, através do registo diário da presença ou ausência nas aulas, podendo ainda ser registadas justificações de faltas, garantindo maior rigor no acompanhamento da assiduidade.

No que diz respeito à componente financeira, o sistema permitirá o registo e controlo das mensalidades escolares, possibilitando aos encarregados de educação efectuar pagamentos através de diferentes meios, tais como numerário, transferência bancária ou carteiras móveis. Um dos principais diferenciais do sistema será a capacidade de validação automática dos pagamentos, permitindo que, após a realização do pagamento, o sistema actualize o estado da mensalidade sem necessidade de intervenção manual constante da administração.

Adicionalmente, os encarregados de educação poderão consultar directamente no sistema o estado dos pagamentos, eliminando a necessidade de deslocação à escola para confirmação, reduzindo assim filas, atrasos e sobrecarga nos serviços administrativos.

O sistema permitirá ainda a consulta de informações académicas, tais como notas e frequência, promovendo maior transparência e comunicação entre a instituição e os encarregados de educação.

Deste modo, a implementação do Sistema de Gestão Escolar desde a fase inicial da instituição permitirá não só melhorar a organização interna, mas também proporcionar maior autonomia aos utilizadores, reduzir processos manuais, minimizar erros e melhorar significativamente a qualidade dos serviços prestados.

---

# 📊 **Dados a Recolher por Actor**

(🔥 Esta parte é MUITO importante para banca/avaliador)

---

## 🔶 Administrador do Sistema

* Nome completo
* Email
* Contacto telefónico
* Credenciais de acesso (username e senha)
* Nível de acesso

---

## 🔶 Aluno

* Nome completo
* Data de nascimento
* Sexo
* Número de documento (BI/Passaporte)
* Número de matrícula
* Morada
* Contacto telefónico
* Email (opcional)
* Data de ingresso
* Estado (activo, transferido, etc.)

---

## 🔶 Encarregado de Educação

* Nome completo
* Grau de parentesco
* Número de documento (BI/Passaporte)
* Contacto telefónico
* Email
* Morada
* Indicação se é responsável financeiro

---

## 🔶 Professor

* Nome completo
* Especialidade
* Número de documento
* Contacto telefónico
* Email
* Disciplinas leccionadas

---

## 🔶 Dados Académicos (Sistema)

### 📚 Classe

* Nome (ex: 10ª Classe)
* Nível (Primário/Secundário)

### 🏫 Turma

* Nome (A, B, C)
* Classe associada
* Ano lectivo

### 📘 Disciplina

* Nome
* Classe associada

---

## 🔶 Matrícula

* Aluno
* Turma
* Ano lectivo
* Data de matrícula
* Estado

---

## 🔶 Nota

* Aluno (via matrícula)
* Disciplina
* Trimestre
* Tipo de avaliação
* Valor

---

## 🔶 Frequência

* Aluno (via matrícula)
* Data
* Presença (Sim/Não)
* Justificação
* Observação

---

## 🔶 Pagamento

* Aluno (via matrícula)
* Mês e ano
* Valor esperado
* Valor pago
* Estado (Pago, Pendente, Atrasado)
* Método de pagamento
* Data de pagamento
* Referência/Transação



# 📘 **Requisitos Funcionais do Sistema**

Os requisitos funcionais descrevem as funcionalidades que o sistema deve possuir para satisfazer as necessidades dos seus utilizadores. Estes requisitos definem o comportamento esperado do sistema em diferentes situações.

---

## 🔷 **RF01 – Gestão de Utilizadores**

O sistema deve permitir ao administrador cadastrar, editar e remover utilizadores, incluindo alunos, professores e encarregados de educação.

---

## 🔷 **RF02 – Autenticação de Utilizadores**

O sistema deve permitir que os utilizadores se autentiquem através de credenciais (nome de utilizador e palavra-passe), garantindo acesso de acordo com o seu perfil.

---

## 🔷 **RF03 – Gestão de Perfis e Permissões**

O sistema deve permitir a atribuição de perfis (Administrador, Professor, Aluno e Encarregado), garantindo controlo de acesso às funcionalidades.

---

## 🔷 **RF04 – Gestão do Ano Lectivo**

O sistema deve permitir ao administrador criar, editar e activar anos lectivos.

---

## 🔷 **RF05 – Gestão de Classes**

O sistema deve permitir o cadastro e gestão das classes (ex: 1ª Classe, 10ª Classe).

---

## 🔷 **RF06 – Gestão de Turmas**

O sistema deve permitir a criação e gestão de turmas associadas a uma classe e a um ano lectivo.

---

## 🔷 **RF07 – Gestão de Disciplinas**

O sistema deve permitir o cadastro e associação de disciplinas às classes.

---

## 🔷 **RF08 – Atribuição de Professores**

O sistema deve permitir associar professores às disciplinas e turmas.

---

## 🔷 **RF09 – Cadastro de Alunos**

O sistema deve permitir o registo completo de alunos, incluindo os seus dados pessoais.

---

## 🔷 **RF10 – Cadastro de Encarregados de Educação**

O sistema deve permitir o registo dos encarregados e a sua associação aos alunos.

---

## 🔷 **RF11 – Matrícula de Alunos**

O sistema deve permitir a matrícula dos alunos em turmas específicas dentro de um determinado ano lectivo.

---

## 🔷 **RF12 – Gestão de Notas**

O sistema deve permitir aos professores lançar, editar e consultar notas dos alunos por disciplina e período de avaliação.

---

## 🔷 **RF13 – Cálculo de Médias**

O sistema deve calcular automaticamente as médias dos alunos com base nas notas registadas.

---

## 🔷 **RF14 – Gestão de Frequência**

O sistema deve permitir o registo da presença e ausência dos alunos, bem como a justificação de faltas.

---

## 🔷 **RF15 – Consulta de Dados Académicos**

O sistema deve permitir aos alunos e encarregados consultar notas, frequência e estado da matrícula.

---

## 🔷 **RF16 – Definição de Mensalidades**

O sistema deve permitir ao administrador definir os valores de mensalidades por classe e ano lectivo.

---

## 🔷 **RF17 – Registo de Pagamentos**

O sistema deve permitir o registo de pagamentos efectuados pelos encarregados de educação.

---

## 🔷 **RF18 – Validação de Pagamentos**

O sistema deve validar automaticamente os pagamentos realizados, actualizando o estado da mensalidade (pago, pendente ou em atraso).

---

## 🔷 **RF19 – Consulta de Pagamentos**

O sistema deve permitir aos encarregados consultar o estado das mensalidades e o histórico de pagamentos.

---

## 🔷 **RF20 – Emissão de Comprovativos**

O sistema deve permitir a emissão de comprovativos de pagamento.

---

## 🔷 **RF21 – Geração de Relatórios**

O sistema deve permitir a geração de relatórios académicos e financeiros, tais como:

* Boletins de notas
* Relatórios de frequência
* Relatórios de pagamentos

---

## 🔷 **RF22 – Notificação de Estado de Pagamento**

O sistema deve notificar o encarregado sobre o estado das mensalidades (pagas, pendentes ou em atraso).

---

## 🔷 **RF23 – Consulta Remota**

O sistema deve permitir que alunos e encarregados consultem informações sem necessidade de deslocação à escola.

