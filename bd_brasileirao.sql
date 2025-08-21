create table tb_time(
cd_serie int primary key auto_increment,
posicao int not null,
nome varchar(30) not null,
qt_jogos int not null,
qt_vitorias int not null,
qt_derrotas int not null,
qt_empates int not null,
gol_pro int not null,
gol_contra int not null,
saldo_gol int not null,
pontuacao int not null
);

insert into tb_time
values
(null, 1, 'Flamengo', 19, 13, 4, 2, 39, 12, 27, 43),
(null, 2, 'Palmeiras', 18, 12, 3, 3, 24, 15, 9, 39),
(null, 3, 'Cruzeiro', 20, 11, 5, 4, 32, 14, 18, 38),
(null, 4, 'Bahia', 18, 9, 6, 3, 25, 17, 8, 33),
(null, 5, 'Botafogo', 18, 8, 5, 5, 23, 11, 12, 29),
(null, 6, 'Mirassol', 18, 7, 8, 3, 29, 19, 10, 29),
(null, 7, 'São Paulo', 18, 8, 3, 7, 23, 24, -1, 29),
(null, 8, 'Fluminense', 20, 7, 6, 6, 22, 21, 1, 27),
(null, 9, 'Bragantino', 20, 7, 6, 7, 21, 22, -1, 27),
(null, 10, 'Ceará SC', 19, 7, 4, 8, 19, 19, 0, 25),
(null, 11, 'Atlético-MG', 18, 6, 6, 6, 20, 21, -1, 24),
(null, 12, 'Internacional', 19, 6, 6, 7, 21, 24, -3, 24),
(null, 13, 'Grêmio', 19, 6, 5, 8, 21, 25, -4, 23),
(null, 14, 'Corinthians', 20, 5, 7, 8, 22, 27, -5, 22),
(null, 15, 'Santos', 19, 5, 6, 8, 21, 29, -8, 21),
(null, 16, 'Vasco da Gama', 19, 5, 4, 10, 20, 24, -4, 19),
(null, 17, 'EC Vitória', 20, 5, 4, 11, 20, 29, -9, 19),
(null, 18, 'Juventude', 18, 4, 6, 8, 18, 30, -12, 15),
(null, 19, 'Fortaleza', 19, 3, 6, 10, 19, 31, -12, 15),
(null, 20, 'Sport Recife', 18, 3, 1, 14, 17, 27, -10, 10);