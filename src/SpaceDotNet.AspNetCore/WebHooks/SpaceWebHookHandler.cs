using System.Collections.Generic;
using System.Threading.Tasks;
using SpaceDotNet.Client;

namespace SpaceDotNet.AspNetCore.WebHooks
{
    /// <inheritdoc/>
    public abstract class SpaceWebHookHandler
        : ISpaceWebHookHandler
    {
        /// <inheritdoc/>
        public virtual Task<Commands> HandleListCommandsAsync(ListCommandsPayload payload) 
            => Task.FromResult(new Commands(new List<CommandDetail>()));
        
        /// <inheritdoc/>
        public virtual Task<MenuExtensions> HandleListMenuExtensionsAsync(ListMenuExtensionsPayload payload) 
            => Task.FromResult(new MenuExtensions(new List<MenuExtensionDetail>()));

        /// <inheritdoc/>
        public virtual Task HandleMessageAsync(MessagePayload payload)
            => Task.CompletedTask;

        /// <inheritdoc/>
        public virtual Task HandleMessageActionAsync(MessageActionPayload payload)
            => Task.CompletedTask;

        /// <inheritdoc/>
        public virtual Task HandleMenuActionAsync(MenuActionPayload payload)
            => Task.CompletedTask;
    }
}