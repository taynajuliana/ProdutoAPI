using AutoMapper;
using CRUD_Teste.Data.DTOs;
using CRUD_Teste.Model;

namespace CRUD_Teste.Profiles;

public class ProdutoProfile : Profile
{
	public ProdutoProfile()
	{
		CreateMap<CreateProdutoDTO, Produto>();
        CreateMap<UpdateProdutoDTO, Produto>();
        CreateMap<Produto, UpdateProdutoDTO>();
        CreateMap<Produto, ReadProdutoDTO>();
    }
}
