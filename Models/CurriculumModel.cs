namespace RamiloAlonsoSaraTarea2.Models
{
	public class CurriculumModel
	{

		private int id;
		private string foto;
		private string nombre;
		private string titular;
		private string apellido1;
		private string apellido2;
		private string[] experiencia;
		private string[] educacion;
		private string[] habilidades;
		private string[] idiomas;
		private string mail;
		private string linkedin;
		private string github;
		private string[] tecnologias;


		public CurriculumModel()
		{
		}

		public CurriculumModel(int id, string foto, string nombre, string titular, string apellido1, string apellido2, string[] experiencia, string[] educacion, string[] habilidades, string[] idiomas, string mail, string linkedin, string github, string[] tecnologias)
		{
			this.id = id;
			this.foto = foto;
			this.nombre = nombre;
			this.titular = titular;
			this.apellido1 = apellido1;
			this.apellido2 = apellido2;
			this.experiencia = experiencia;
			this.educacion = educacion;
			this.habilidades = habilidades;
			this.idiomas = idiomas;
			this.mail = mail;
			this.linkedin = linkedin;
			this.github = github;
			this.tecnologias = tecnologias;
		}

		public CurriculumModel crearPerfil1()
		{
			string[] experiencia = new string[] { "Desarrolladora backend: Boycor (2023-actualidad)", "Desarrolladora web: Ayuntamiento de Vigo, Formaweb IV (2021-2022)", "Editora de vídeo: Pumpún Dixital (2020)" };
			string[] educacion = new string[] { "Grado en Comunicación Audiovisual (2016-2020) | Universidad de Vigo", "Certificado de profesionalidad en Desarrollo de aplicaciones con tectonogías web (2021-2022)", "Certificado de profesionalidad en Sistemas de gestión de la información (2021-2022)", "Ciclo Superior en Desarrolo de Aplicaciones Web (2022-2024) | Colexio de Fomento Montecastelo" };
			string[] habilidades = new string[] { "Java: nivel avanzado", "Adobe Experience Manager: nivel medio", "SQL: nivel avanzado", "ASP.NET: nivel básico", "HTML y CSS: nivel avanzado", "Edición de vídeo: nivel avanzado"};
			string[] idiomas = new string[] { "Inglés: Cambridge English First | MCER C1", "Gallego: CELGA 4" };
			String imgPath = "wwwroot/img/tecnologias";
			String[] rutaImgTec = Directory.GetFiles(imgPath);
			String[] rutaImgTecWeb = new String[rutaImgTec.Length];
			for (int i = 0; i < rutaImgTec.Length; i++)
			{
				var webPath = rutaImgTec[i].Replace("wwwroot", "");
				rutaImgTecWeb[i] = webPath;
			}

			CurriculumModel perfil1 = new CurriculumModel(1, "/img/profileImage.jpg", "Sara", "Web Developer y Comunicadora", "Ramilo", "Alonso", experiencia, educacion, habilidades, idiomas, "sara.ramilo.alonso@ciclosmontecastelo.com", "https://www.linkedin.com/in/sara-ramilo", "https://github.com/sram-daw", rutaImgTecWeb);
			return perfil1;
		}


		public int Id { get => id; set => id = value; }
		public string Foto { get => foto; set => foto = value; }
		public string Titular { get => titular; set => titular = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Apellido1 { get => apellido1; set => apellido1 = value; }
		public string Apellido2 { get => apellido2; set => apellido2 = value; }
		public string[] Experiencia { get => experiencia; set => experiencia = value; }
		public string[] Educacion { get => educacion; set => educacion = value; }
		public string[] Habilidades { get => habilidades; set => habilidades = value; }
		public string[] Idiomas { get => idiomas; set => idiomas = value; }
		public string Mail { get => mail; set => mail = value; }
		public string Linkedin { get => linkedin; set => linkedin = value; }
		public string Github { get => github; set => github = value; }
		public string[] Tecnologias { get => tecnologias; set => tecnologias = value; }
	}
}
