INSERT INTO UF(NOME, UF) VALUES
('SÃO PAULO', 'SP'),
('MINAS GERAIS', 'MG'),
('PERNAMBUCO', 'PE'),
('BAHIA', 'BA'),
('MATO GROSSO', 'MT'),
('RIO DE JANEIRO', 'RJ'),
('SANTA CATARINA', 'SC'),
('GOIAS', 'GO');

INSERT INTO CIDADE(CODUF, NOME) VALUES
(1, 'SAO JOSE DO RIO PRETO'), (1, 'SANTOS'), (1, 'CAMPINAS'), (1, 'MAUA'), (1, 'SAO PAULO'),
(2, 'POCOS DE CALCA'), (2, 'CAMPINA VERDE'), (2, 'CAMPO AZUL'), (2, 'DIAMANTINA'),
(3, 'CARUARU'), (3, 'PRETOLINA'),
(4, 'GUANAMBI'), (4, 'BRUMADO'), (4, 'PORTO SEGURO'), (4, 'ALAGOINHAS'),
(5, 'CUIABA'), (5, 'VILA RICA'), 
(6, 'CABO FRIO'), (6, 'CAMBUCI'), (6, 'CARMO'),
(7, 'ANGELINA'), (7, 'ANCHIETA'),
(8, 'GOIANIA'), (8, 'RIO VERDE'), (8, 'FORMOSA'), (8, 'CALDAS NOVAS');

INSERT INTO USUARIO(NOME, SENHA) VALUES ('JTD', 'FROTAS');

INSERT INTO TIPOCARTA (TIPO, DESCRICAO) VALUES
('CNH Categoria A','Para condutor de veículo motorizado de 2 ou 3 rodas, como motos ou triciclos.'),
('CNH Categoria B','Para condutor de veículo motorizado cujo peso total não deve exceder 3500 kg, com lotação máxima de 8 ocupantes. Ex: carros de passeio.'),
('CNH Categoria C','Para condutor de veículo motorizado utilizado para transporte de carga, com o peso bruto para além de 3500 kg.'),
('CNH Categoria D','Para condutor de veículo motorizado que trabalhe com transporte de passageiros em veículo com mais de 8 lugares.'),
('CNH Categoria E','Para condutor de veículo motorizado que se enquadre nas categorias B, C ou D e sobre o qual esteja acoplada uma carroceria reboque, semi-reboque ou articulada com 6000 kg ou mais.');

INSERT INTO MARCAVEICULO(NOME) VALUES 
('FIAT'),
('CHEVROLET'),
('VOLKSWAGEN'),
('FORD'),
('RENAULT'),
('TOYOTA'),
('HONDA'),
('HYUNDAI');

INSERT INTO MODELOVEICULO(CODMARCAVEICULO, NOME) VALUES
(1, 'PUNTO'), (1, 'STRADA'), (1, 'UNO'), (1, 'SIENA'),
(2, 'CORSA'), (2, 'CELTA'), (2, 'ONIX'), (2, 'COBALT'),
(3, 'GOL'), (3, 'FOX'), (3, 'VOYAGE'), (3, 'SAVEIRO'),
(4, 'ECOSPORT'), (4, 'FOCUS'), (4, 'FIESTA'),
(5, 'LOGAN'), (5, 'SANDERO'), (5, 'DUSTER'), (5, 'CLIO'),
(6, 'COROLLA'), (6, 'HILUX'), (6, 'ETIOS'),
(7, 'CIVIC'), (7, 'FIT'), (7, 'HR-V'),
(8, 'I30'), (8, 'HB20'), (8, 'TUCSON');

