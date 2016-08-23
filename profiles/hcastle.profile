<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Haunted Castle"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Characters">
			<plane>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
			</plane>
			<x multiplier="4">
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="4" />
				<offset bits="5" />
			</x>
			<y multiplier="32">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</y>
			<stride>256</stride>
		</layout>
	</layouts>

	<regions>
		<region name="gfx1" length="100000">
			<file name="g21">
				<load offset="000000" size="80000" />
			</file>
			<file name="g19">
				<load offset="080000" size="80000" />
			</file>
		</region>
		<region name="gfx2" length="100000">
			<file name="j5">
				<load offset="000000" size="80000" />
			</file>
			<file name="j6">
				<load offset="080000" size="80000" />
			</file>
		</region>
	</regions>
</profile:profile>