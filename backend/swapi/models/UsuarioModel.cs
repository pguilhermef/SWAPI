class Usuario
{
  public required string Nome { get; set; }
  public required string Email {get; set; }
  public Guid Id {get; set;} = Guid.NewGuid();
}