namespace Application.UseCases
{
    using System;
    using System.Threading.Tasks;
    using Application.Boundaries.Register;

    /// <summary>
    /// Register <see href="https://github.com/ivanpaulovich/clean-architecture-manga/wiki/Domain-Driven-Design-Patterns#use-case">Use Case Domain-Driven Design Pattern</see>.
    /// </summary>
    public sealed class Register : IUseCase
    {
        /// <summary>
        /// Executes the Use Case.
        /// </summary>
        /// <param name="input">Input Message.</param>
        /// <returns>Task.</returns>
        public Task Execute(RegisterInput input)
        {
            throw new NotImplementedException();
        }
    }
}
