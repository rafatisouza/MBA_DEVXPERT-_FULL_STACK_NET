# Feedback - Avaliação Geral

## Front End

### Navegação
  * Pontos positivos:
    - Projeto MVC básico com navegação funcional para produtos via scaffolding.

  * Pontos negativos:
    - CRUD de categorias ausente.
    - Vendedor sendo gerenciado diretamente por CRUD, o que é desnecessário.
    - Produto não vinculado ao usuário logado.

### Design
  - Interface padrão gerada por scaffolding. Funcional, mas não personalizada.

### Funcionalidade
  * Pontos positivos:
    - CRUD de produtos presente na camada MVC.
    - Uso do SQLite como base de dados.
    - Migrations automáticas e seed de dados configurados.

  * Pontos negativos:
    - CRUD de categorias ausente.
    - CRUD da API é apenas estrutural (esqueleto), sem implementação.
    - Duplicação de entidades e lógica entre MVC e API.
    - Identity não configurado corretamente em nenhuma das camadas.
    - Vendedor não é criado no momento do registro do usuário com ID compartilhado.

## Back End

### Arquitetura
  * Pontos positivos:
    - Separação básica entre MVC e API em projetos distintos.

  * Pontos negativos:
    - Ausência de camada agregadora (Core).
    - Lógica de negócio e entidades duplicadas nas duas camadas.
    - Estrutura não favorece reutilização e manutenção do código.

### Funcionalidade
  * Pontos positivos:
    - Funcionalidades básicas operacionais no MVC.

  * Pontos negativos:
    - API sem operações funcionais.
    - Sem controle de propriedade sobre produtos (vínculo com vendedor).
    - Cadastro de vendedor manual via CRUD, em vez de associado ao Identity.

### Modelagem
  * Pontos positivos:
    - Modelagem simples e compatível com CRUDs.

  * Pontos negativos:
    - Duplicidade de estrutura entre camadas.

## Projeto

### Organização
  * Pontos positivos:
    - Projeto separado em `src`, com solution `.sln` na raiz.

  * Pontos negativos:
    - Muitos arquivos desnecessários versionados (.vs, arquivos temporários, banco de dados).
    - Sem documentação adequada no `README.md`.

### Documentação
  * Pontos positivos:
    - `README.md` presente.

  * Pontos negativos:
    - Conteúdo do README incompleto e sem relação com a entrega.

### Instalação
  * Pontos positivos:
    - SQLite com migrations e seed automatizados.

  * Pontos negativos:
    - Duplicação de seed nos dois projetos.

---

# 📊 Matriz de Avaliação de Projetos

| **Critério**                   | **Peso** | **Nota** | **Resultado Ponderado**                  |
|-------------------------------|----------|----------|------------------------------------------|
| **Funcionalidade**            | 30%      | 5        | 1,5                                      |
| **Qualidade do Código**       | 20%      | 6        | 1,2                                      |
| **Eficiência e Desempenho**   | 20%      | 5        | 1,0                                      |
| **Inovação e Diferenciais**   | 10%      | 5        | 0,5                                      |
| **Documentação e Organização**| 10%      | 5        | 0,5                                      |
| **Resolução de Feedbacks**    | 10%      | 8        | 0,8                                      |
| **Total**                     | 100%     | -        | **5,5**                                  |

## 🎯 **Nota Final: 5,5 / 10**
