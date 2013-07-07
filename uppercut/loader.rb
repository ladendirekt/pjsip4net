require 'rubygems'

module Uppercutbuild
  class Loader

	def self.load()
      @gem_to_copy = 'uppercutbuild'
      
      start_here = get_copy_from()
      puts "Copy From: #{start_here}"
      
      to = get_copy_to()
      puts "Copy To: #{to}"
      
      FileUtils.copy_entry start_here, to
	end

	def self.upgrade()
      @gem_to_copy = 'uppercutbuild'
      
      start_here = get_copy_from()
      start_here = File.join(start_here,"build")
      puts "Copy From: #{start_here}"
      
      to = get_copy_to()
      to = File.join(to,"build")
      puts "Copy To: #{to}"
      
      FileUtils.copy_entry start_here, to
	end
	
    def self.get_libdir(name)
      g = get_gemspec name
      #puts "GemSpec #{g.full_gem_path}"
      l = g.full_gem_path
      d = File.join(l,"lib")
      #puts d
      d
    end
    
    def self.get_gemspec(name)
      gems = Gem.source_index.find_name name
      return gems.last if gems.length > 0
    end
	    
    def self.get_copy_from
      libdir = get_libdir @gem_to_copy
    end
    
    def self.get_files
      spec = get_gemspec @gem_to_copy
      files = spec.lib_files #get full path
      files
    end
    
    def self.get_copy_to
      spec = get_gemspec @gem_to_copy
      #to be used in copying
      name =  spec.full_name
      to = Dir.pwd
      to
    end
	
	def self.process_dependencies
		spec = get_gemspec @gem_to_copy
		spec.dependencies.each do |d|
			if Gem.available? d.name
				puts "loading #{d.name}"
				load d.name, @location
			else
				puts "#{d.name} is not installed locally"
				puts "please run 'gem install #{d.name}"
			end
		end
	end
  end
end
