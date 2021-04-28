USE Senai_HROADS_Manha;

--Tarefa 10 (Realizar a contagem de quantas habilidades estão cadastradas)
SELECT COUNT  (IdHabilidade) AS [Quant. de Habilidades]
FROM           Habilidade;


--Tarefa 11 (Selecionar somente os id’s das habilidades classificando-os por ordem crescente)
SELECT   IdHabilidade
FROM     Habilidade
ORDER BY IdHabilidade ASC;


--Tarefa 12 (Selecionar todos os tipos de habilidades)
SELECT * FROM TipoHabilidade;


--Tarefa 13 (Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte)
SELECT      Habilidade.NomeHabilidade As Habilidade, TipoHabilidade.TipoHabilidade AS Genero FROM Habilidade
LEFT JOIN   TipoHabilidade
ON          Habilidade.IdTipoHabilidade = TipoHabilidade.IdTipoHabilidade;

--Tarefa 14 (Selecionar todos os personagens e suas respectivas classes)
SELECT      Personagem.NomePersonagem AS Personagem, Classe.NomeClasse AS Classe FROM Personagem
LEFT JOIN   Classe
ON          Personagem.IdClasse = Classe.IdClasse;


--Tarefa 15 (Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens))
SELECT      Personagem.NomePersonagem AS Personagem , Classe.NomeClasse AS Classe FROM Personagem
RIGHT JOIN  Classe
ON          Personagem.IdClasse = Classe.IdClasse;


--Tarefa 16 (Selecionar todas as classes e suas respectivas habilidades)
SELECT      Classe.NomeClasse AS Classe, Habilidade.NomeHabilidade AS Habilidades FROM ClasseHabilidade
INNER JOIN  Habilidade
ON          Habilidade.IdHabilidade = ClasseHabilidade.IdHabilidade
INNER JOIN  Classe
ON          Classe.IdClasse = ClasseHabilidade.IdClasse;


--Tarefa 17 (Selecionar todas as habilidades e suas classes (somente as que possuem correspondência))
SELECT      Habilidade.NomeHabilidade AS Habilidade, Classe.NomeClasse AS Classe FROM ClasseHabilidade
INNER JOIN  Habilidade
ON          Habilidade.IdHabilidade = ClasseHabilidade.IdHabilidade
INNER JOIN  Classe
ON          Classe.IdClasse = ClasseHabilidade.IdClasse;


--Tarefa 18 (Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência).)
SELECT      Habilidade.NomeHabilidade AS Habilidade, Classe.NomeClasse AS Classe FROM ClasseHabilidade
LEFT JOIN   Habilidade
ON          Habilidade.IdHabilidade = ClasseHabilidade.IdHabilidade
LEFT JOIN   Classe
ON          Classe.IdClasse = ClasseHabilidade.IdClasse;
