# 📘 **Casos de Uso do Sistema *SmartSchoolMZ***

O Sistema de Gestão Escolar contará com diferentes actores, cada um com permissões específicas que determinam as funcionalidades que podem executar no sistema. Os principais actores identificados são: Administrador, Professor, Aluno e Encarregado de Educação.

A seguir, são apresentados os casos de uso associados a cada actor.

---

# 🔷 **Actor: Administrador**

O Administrador é responsável pela gestão global do sistema, incluindo o cadastro de utilizadores e a configuração da estrutura académica.

### 📌 Casos de Uso:

* Cadastrar utilizadores (alunos, professores, encarregados)
* Editar e remover utilizadores
* Criar e gerir anos lectivos
* Definir classes e turmas
* Cadastrar disciplinas
* Atribuir professores às disciplinas e turmas
* Realizar matrícula de alunos
* Definir valores de mensalidades
* Consultar relatórios académicos e financeiros
* Validar e acompanhar pagamentos
* Gerir permissões de acesso

---

# 🔷 **Actor: Professor**

O Professor é responsável pelas actividades académicas relacionadas ao ensino e avaliação dos alunos.

### 📌 Casos de Uso:

* Consultar turmas atribuídas
* Consultar disciplinas leccionadas
* Lançar notas dos alunos
* Editar notas
* Registar frequência (presença/ausência)
* Justificar faltas (quando aplicável)
* Consultar desempenho dos alunos

---

# 🔷 **Actor: Aluno**

O Aluno tem acesso limitado ao sistema, podendo consultar as suas informações académicas.

### 📌 Casos de Uso:

* Consultar notas
* Consultar frequência
* Consultar dados pessoais
* Consultar estado de matrícula

---

# 🔷 **Actor: Encarregado de Educação**

O Encarregado de Educação é responsável pelo acompanhamento académico e financeiro do aluno.

### 📌 Casos de Uso:

* Consultar dados do aluno
* Consultar notas do aluno
* Consultar frequência do aluno
* Consultar estado de pagamentos
* Efectuar pagamentos de mensalidades
* Consultar histórico de pagamentos
* Receber confirmação/validação de pagamentos

---

# 🔷 **Casos de Uso Críticos do Sistema (Destaque)**

Alguns casos de uso são considerados críticos para o bom funcionamento do sistema:

### 💰 Gestão de Pagamentos

* Registo de pagamentos
* Validação automática de pagamentos
* Actualização do estado da mensalidade
* Consulta em tempo real pelo encarregado

---

### 🎓 Gestão Académica

* Matrícula de alunos
* Lançamento de notas
* Cálculo de médias

---

### 📅 Controle de Frequência

* Registo diário de presença
* Justificação de faltas
* Consulta de assiduidade

---

# 🔷 **Resumo dos Actores e Interacções**

| Actor         | Interacção Principal        |
| ------------- | --------------------------- |
| Administrador | Gestão total do sistema     |
| Professor     | Ensino e avaliação          |
| Aluno         | Consulta académica          |
| Encarregado   | Acompanhamento e pagamentos |
