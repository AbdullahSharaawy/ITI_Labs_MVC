using Sharaawy_BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharaawy_DAL.Entities;
using Riok.Mapperly.Abstractions;
namespace Sharaawy_BL.Mapperly
{
    [Mapper]
    public partial class DepartmentMapper
    {
        [MapProperty(nameof(Department.Id), nameof(DepartmentDTO.ID))]
        [MapProperty(nameof(Department.Name), nameof(DepartmentDTO.Name))]
        [MapProperty(nameof(Department.Manager), nameof(DepartmentDTO.Manager))]
        public partial DepartmentDTO MapToDepartmentDTO(Department department);
        public partial List<DepartmentDTO> MapToDepartmentDTOList(List<Department> departments);
    }
}
