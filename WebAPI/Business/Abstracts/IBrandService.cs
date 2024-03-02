using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
                                       // Veri tabanı nesnesini asla son kullanıcıya döndürmüyoruz ve ondan istemiyoruz   !!sadece ihtiyaç kadarını
    CreatedBrandResponse Add(CreateBrandRequest CreatebrandRequest);           //hangi marka eklendiyse o markanın eklenme datasını son kullanıcıya verebiliriz

    List<GetAllBrandResponse> GetAll();

    //Responses and Reguests  =>  Yanıtlar ve istekler
}
