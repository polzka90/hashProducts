# Hash Products Service 2

Teste Backend da empresa Hash, diretamente relacionado com [HashDiscount](https://github.com/polzka90/hashDiscount)
## Requerimentos

 1. Ter instalado Docker
 2. Ter instalado PostgreSQL na maquina local
 3. Ter Instalado VSCode
 4. Ter Instalado Git
 5. Ter Instalado Postman


## Pasos

1. Abrir PgAdmin e criar um banco de dados de nome HashDb(se esta não existe ja)
2. Clonar o Repositorio tudo com Git
3. usar o arquivo HashDb.backup dentro do repositorio para restaurar o banco (se não foi feito antes)
4. Configurar os acessos para o container conectar em postgreSql mediante a configuração dos siguentes arquivos na pasta de instalação:
	
	4.1. no arquivo postgresql.conf verificar que a seguente linha esta descomentada listen_addresses = '*'
	
	4.2. pg_hba.conf adicionar a siguente linha 
	
	\# TYPE DATABASE USER CIDR-ADDRESS  METHOD
	
	  host   all     all   0.0.0.0/0     md5
	  
5. na raiz do projeto e ir na pasta HashProducts configurar o arquivo appsettings.json para ter o acessos certo ao banco e demais configurações
	5.1 o host na configuração do banco dever ser o ip da maquina donde esta o banco, não pode ser localhost
6. configurar tambem os arquivos Dockerfile e docker-compose.yml para ter acessos aos portos se for o caso
7. criar a rede hash-network com o comando 'docker network create -d bridge hash-network'
8. ir na raiz do projeto e executar o comando "docker-compose up -d" para criar o container e começar a funcionar
9. verificar o console do docker que o serviço rodou corretamente, ignorar mensagens de configuração de SSL
10. Pode usar o arquivo Hash.postman_collection.json dentro da raiz do projeto para importar no postman a collection para chamar o serviço
11. em alguns casos pode acontecer que a hora do container esta diferente da do host, nesse caso é so reiniciar o serviço de docker




