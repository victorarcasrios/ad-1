//GitHub>@juankza

using PReflection;
using System;

public class Categoria
{

	public Categoria (ulong id, string nombre)
	{
		this.id = id;
		this.nombre = nombre;

	}

	[Id]
	private ulong id;
	private string nombre;

	public ulong Id
	{
		get { return id;}
		set { id = value;}
	}
	public string Nombre
	{
		get { return nombre;}
		set { nombre = value;}
	}

}
