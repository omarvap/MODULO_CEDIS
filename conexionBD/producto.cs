//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace conexionBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public int id { get; set; }
        public int id_cat { get; set; }
        public int id_pres { get; set; }
        public int id_unidad { get; set; }
        public int id_marca { get; set; }
        public string nombre { get; set; }
        public byte[] imagen { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public int Ubicacion { get; set; }
    
        public virtual categoria categoria { get; set; }
        public virtual marca marca { get; set; }
        public virtual presentacion presentacion { get; set; }
        public virtual unidad_medida unidad_medida { get; set; }
        public virtual ABC ABC { get; set; }
    }
}
