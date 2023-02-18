ClientePractica client = new ClientePractica("Antonio Villasante", "24234-432", "Beccar Varela", "example@email.com", true);
Console.WriteLine(client.ToString());
public struct ClientePractica
{

    string nombre;
    string telefono;
    string direccion;
    string email;
    bool nuevo;

    public ClientePractica(string nom, string tel, string dirc, string em, bool nue)
    {
        nombre = nom;
        telefono = tel;
        direccion = dirc;
        email = em;
        nuevo = nue;
    }
    public override string ToString() => $"Cliente {nombre}, telefono: {telefono}, direccion: {direccion}, email: {email} , nuevo: {nuevo}";
}