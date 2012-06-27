using Contexteer;
using Machine.Specifications;

namespace FeatureSwitcher.Specs
{
    // ReSharper disable InconsistentNaming
    // ReSharper disable UnusedMember.Local
    [Behaviors]
    public class Enabled<TBase, TFeature> where TFeature : TBase, new() where TBase : IFeature
    {
        It should_be_enabled_as_instance = () => ((TBase)new TFeature()).Is().Enabled.ShouldBeTrue();

        It should_be_not_disabled_as_instance = () => ((TBase)new TFeature()).Is().Disabled.ShouldBeFalse();
    }

    [Behaviors]
    public class Enabled<TFeature> where TFeature : IFeature, new()
    {
        It should_be_enabled_as_generic = () => Feature<TFeature>.Is().Enabled.ShouldBeTrue();

        It should_be_enabled_as_instance = () => new TFeature().Is().Enabled.ShouldBeTrue();

        It should_be_not_disabled_as_generic = () => Feature<TFeature>.Is().Disabled.ShouldBeFalse();

        It should_be_not_disabled_as_instance = () => new TFeature().Is().Disabled.ShouldBeFalse();
    }

    [Behaviors]
    public class EnabledInDefault<TFeature> where TFeature : IFeature, new()
    {
        It should_be_enabled_as_generic = () => Feature<TFeature>.Is().EnabledInContextOf(Default.Context).ShouldBeTrue();

        It should_be_enabled_as_instance = () => new TFeature().Is().EnabledInContextOf(Default.Context).ShouldBeTrue();

        It should_be_not_disabled_as_generic = () => Feature<TFeature>.Is().DisabledInContextOf(Default.Context).ShouldBeFalse();

        It should_be_not_disabled_as_instance = () => new TFeature().Is().DisabledInContextOf(Default.Context).ShouldBeFalse();
    }

    [Behaviors]
    public class EnabledInHeadquaters<TFeature> where TFeature : IFeature, new()
    {
        It should_be_enabled_as_generic = () => Feature<TFeature>.Is().EnabledInContextOf(BusinessBranch.Headquarters).ShouldBeTrue();

        It should_be_enabled_as_instance = () => new TFeature().Is().EnabledInContextOf(BusinessBranch.Headquarters).ShouldBeTrue();

        It should_be_not_disabled_as_generic = () => Feature<TFeature>.Is().DisabledInContextOf(BusinessBranch.Headquarters).ShouldBeFalse();

        It should_be_not_disabled_as_instance = () => new TFeature().Is().DisabledInContextOf(BusinessBranch.Headquarters).ShouldBeFalse();
    }

    [Behaviors]
    public class Disabled<TFeature> where TFeature : IFeature, new()
    {
        It should_be_disabled_as_generic = () => Feature<TFeature>.Is().Disabled.ShouldBeTrue();

        It should_be_disabled_as_instance = () => new TFeature().Is().Disabled.ShouldBeTrue();

        It should_be_not_enabled_as_generic = () => Feature<TFeature>.Is().Enabled.ShouldBeFalse();

        It should_be_not_enabled_as_instance = () => new TFeature().Is().Enabled.ShouldBeFalse();
    }

    [Behaviors]
    public class DisabledInDefault<TFeature> where TFeature : IFeature, new()
    {
        It should_be_disabled_as_generic = () => Feature<TFeature>.Is().DisabledInContextOf(Default.Context).ShouldBeTrue();

        It should_be_disabled_as_instance = () => new TFeature().Is().DisabledInContextOf(Default.Context).ShouldBeTrue();

        It should_be_not_enabled_as_generic = () => Feature<TFeature>.Is().EnabledInContextOf(Default.Context).ShouldBeFalse();

        It should_be_not_enabled_as_instance = () => new TFeature().Is().EnabledInContextOf(Default.Context).ShouldBeFalse();
    }

    [Behaviors]
    public class DisabledInHeadquaters<TFeature> where TFeature : IFeature, new()
    {
        It should_be_disabled_as_generic = () => Feature<TFeature>.Is().DisabledInContextOf(BusinessBranch.Headquarters).ShouldBeTrue();

        It should_be_disabled_as_instance = () => new TFeature().Is().DisabledInContextOf(BusinessBranch.Headquarters).ShouldBeTrue();

        It should_be_not_enabled_as_generic = () => Feature<TFeature>.Is().EnabledInContextOf(BusinessBranch.Headquarters).ShouldBeFalse();

        It should_be_not_enabled_as_instance = () => new TFeature().Is().EnabledInContextOf(BusinessBranch.Headquarters).ShouldBeFalse();
    }
    // ReSharper restore UnusedMember.Local
    // ReSharper restore InconsistentNaming
}