using AquariumPeek.Application.TodoLists.Queries.ExportTodos;

namespace AquariumPeek.Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
