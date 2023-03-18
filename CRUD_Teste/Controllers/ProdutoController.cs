using AutoMapper;
using CRUD_Teste.Data;
using CRUD_Teste.Data.DTOs;
using CRUD_Teste.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRUD_Teste.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private ProdutoContext _context;
    public IMapper _mapper;

    public ProdutoController(ProdutoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaProduto([FromBody] CreateProdutoDTO produtoDto)
    {
        Produto p = _mapper.Map<Produto>(produtoDto);
        _context.Add(p);
        _context.SaveChanges();
        return Ok();
    }
    [HttpGet]
    public IEnumerable<ReadProdutoDTO> RetornaProduto([FromQuery]int skip = 0, [FromQuery]  int take = 0)
    {
        return _mapper.Map<List<ReadProdutoDTO>>(_context.Produtos.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult RetornaProdutoPorId(int id)
    {
        var obj = _context.Produtos.Find(id);
        if (obj == null)
        {
            return NotFound();
        }

        return Ok(obj);
    }
    [HttpPut("{id}")]
    public IActionResult AtualizaProduto(int id,
        [FromBody] UpdateProdutoDTO produtoDTO)
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null) return NotFound();
        _mapper.Map(produtoDTO, produto);
        _context.SaveChanges();
        return NoContent();
    }
    [HttpPatch("{id}")]
    public IActionResult AtualizaProdutoParcial(int id,
        JsonPatchDocument<UpdateProdutoDTO> patch)
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null) return NotFound();
        var produtoAtualizar = _mapper.Map<UpdateProdutoDTO>(produto);
        patch.ApplyTo(produtoAtualizar);
        if (!TryValidateModel(produtoAtualizar))
        {
            return ValidationProblem(ModelState);
        }
        _mapper.Map(produtoAtualizar, produto);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaProduto(int id)
    {
        var p =_context.Produtos.FirstOrDefault(p => p.Id == id);   
        if(p ==null)return NotFound();
        _context.Remove(p);
        _context.SaveChanges();
        return NoContent();
    }
}
