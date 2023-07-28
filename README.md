# dotnetWebAPI

Creation of a simple CRUD following the tutorial available on the internet.


## API Reference

#### Obter todos os usuários (Get all users)

```http
  GET /api/usuario
```


#### Obter usuário por ID (Get user by ID)

```http
  GET /api/usuario/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of User to fetch |

#### Adicionar novo usuário (Add new user)

```http
  POST /api/usuario
```

#### Atualizar usuário existente (Update existing user)

```http
  PUT /api/usuario/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of User to update |

#### Excluir usuário (Delete User)

```http
  DELETE /api/usuario/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of User to delete |

#### Above provides a description of the UsuarioController API that allows managing users through various HTTP operations (GET, POST, PUT, and DELETE).


## Thanks

- To generated this Readme I use the Readme.so from - [@octokatherine](https://www.github.com/octokatherine)

- I followed the tutorial on YouTube by [@Pablofr10](https://github.com/Pablofr10). Video: https://www.youtube.com/watch?v=NMplO55WD4k



