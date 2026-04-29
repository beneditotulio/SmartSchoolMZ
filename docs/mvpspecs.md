# 🎓 SmartSchoolMz - Sistema de Gestão Escolar

## 📌 Descrição

O **EduCore** é um sistema de gestão escolar desenvolvido para instituições de ensino da 1ª à 12ª Classe, com o objectivo de automatizar processos académicos, administrativos e financeiros.

O sistema foi concebido para reduzir a dependência de processos manuais, diminuir filas na instituição e permitir que alunos e encarregados consultem informações remotamente.

---

## 🚀 Objectivo do MVP

O MVP (Minimum Viable Product) tem como objectivo validar as funcionalidades essenciais do sistema, nomeadamente:

* Gestão de utilizadores
* Matrícula de alunos
* Lançamento de notas
* Registo de frequência
* Gestão de pagamentos
* Consulta remota por encarregados

---

## 🧱 Funcionalidades do MVP

### 👤 Autenticação

* Login com ASP.NET Identity
* Perfis: Admin, Professor, Encarregado

---

### 🎓 Gestão Académica

* Cadastro de alunos
* Cadastro de professores
* Cadastro de classes e turmas
* Matrícula de alunos

---

### 📝 Notas

* Lançamento de notas por disciplina
* Consulta de notas

---

### 📅 Frequência

* Registo de presença/ausência
* Consulta de frequência

---

### 💰 Pagamentos

* Registo de pagamentos
* Estado: Pago / Pendente
* Consulta de pagamentos pelo encarregado

---

## 🧠 Conceito Central

O sistema baseia-se na entidade **Matrícula**, que representa o vínculo do aluno com uma turma e ano lectivo.

Tudo está associado à matrícula:

* Notas
* Frequência
* Pagamentos

---

## 🛠️ Tecnologias

* Backend: ASP.NET Core Web API
* Frontend: (opcional) React / Razor Pages
* Base de Dados: SQL Server
* ORM: Entity Framework Core
* Autenticação: ASP.NET Identity

---

## 📦 Estrutura do Projecto

* Domain
* Application
* Infrastructure
* WebAPI

---

## 🔐 Diferenciais

* Validação de pagamentos
* Consulta remota (redução de filas)
* Modelo escalável (SaaS ready)

---

## 📈 Próximas Funcionalidades

* Integração com M-Pesa / e-Mola
* Notificações por SMS
* Dashboard analítico
* Aplicação móvel

---

## 👨‍💻 Autor

Desenvolvido por:
* Túlio Benedito Nhantumbo