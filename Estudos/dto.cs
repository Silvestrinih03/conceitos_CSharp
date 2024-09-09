using System;
using System.Linq;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PasswordHash { get; set; }
}

public class UserDTO
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
}

public class UserRepository
{
    private List<User> users = new List<User>
    {
        new User { Id = 1, FirstName = "Nicole", LastName = "Silvestrini", Email = "nicole.silvestrini@example.com", DateOfBirth = new DateTime(1998, 5, 23), PasswordHash = "hashed_password_1" },
        new User { Id = 2, FirstName = "Bruno", LastName = "Oliveira", Email = "bruno.oliveira@example.com", DateOfBirth = new DateTime(1995, 10, 15), PasswordHash = "hashed_password_2" },
    };

    public User GetById(int id)
    {
        return users.FirstOrDefault(u => u.Id == id);
    }
}

public class UserService
{
    private UserRepository userRepository;

    public UserService()
    {
        userRepository = new UserRepository(); // Inicializa o repositório
    }

    public UserDTO GetUserById(int id)
    {
        User user = userRepository.GetById(id); // Recupera o usuário do banco de dados

        if (user == null)
        {
            return null; // Ou lançar uma exceção, dependendo do caso
        }

        // Mapeia a entidade User para o DTO UserDTO
        UserDTO userDTO = new UserDTO
        {
            Id = user.Id,
            FullName = $"{user.FirstName} {user.LastName}",
            Email = user.Email
        };

        return userDTO;
    }
}


class Program
{
    static void Main()
    {        
        UserService userService = new UserService();

        UserDTO userDTO = userService.GetUserById(1);

        if (userDTO != null)
        {
            Console.WriteLine($"ID: {userDTO.Id}");
            Console.WriteLine($"Nome Completo: {userDTO.FullName}");
            Console.WriteLine($"Email: {userDTO.Email}");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado.");
        }
    }
}
