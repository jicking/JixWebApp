using JixWebApp.Core.DTO;
using JixWebApp.Core.Entities;
using Mapster;

namespace JixWebApp.Core;
public static class ModelMapping {

	public static ProjectDto ToDto(this Project model) {
		if (model == null) return null;
		return model.Adapt<ProjectDto>();
	}

	public static List<ProjectDto> ToDto(this IList<Project> model) {
		var result = new List<ProjectDto>();
		foreach (var item in model)
			result.Add(item.ToDto());
		return result;
	}

	public static Project ToEntity(this ProjectDto dto) {
		if (dto == null) return null;
		return dto.Adapt<Project>();
	}

	// map action dto (eg: create, update) if exists to dto
	public static ProjectDto ToDto(this CreateProjectDto model) {
		return model.Adapt<ProjectDto>();
	}
}
